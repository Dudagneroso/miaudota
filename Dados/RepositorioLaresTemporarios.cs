using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miaudota
{
    public class LarTemporarioCombo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string TextoExibicao
        {
            get { return $"{Nome} (ID: {Id})"; }
        }
    }

    internal class RepositorioLaresTemporarios
    {
        private static List<LarTemporario> cache = new List<LarTemporario>();
        private static readonly object bloqueio = new object();
        private const int LIMITE_CACHE = 5;

        public static int QuantidadePendente()
        {
            lock (bloqueio)
            {
                return cache.Count;
            }
        }

        public static void Adicionar(LarTemporario lar)
        {
            if (lar == null)
                throw new ArgumentNullException(nameof(lar));

            bool sincronizar;

            lock (bloqueio)
            {
                if (cache.Any(l => l.Cpf == lar.Cpf))
                {
                    throw new InvalidOperationException(
                        "Já existe um lar com esse CPF aguardando sincronização.");
                }

                cache.Add(lar);
                sincronizar = cache.Count >= LIMITE_CACHE;
            }

            if (sincronizar)
                Sincronizar();
        }

        public static void Sincronizar()
        {
            List<LarTemporario> lote;

            lock (bloqueio)
            {
                if (cache.Count == 0)
                    return;

                lote = cache.ToList();
            }

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlTransaction transacao = conexao.BeginTransaction())
                {
                    try
                    {
                        foreach (LarTemporario lar in lote)
                            Inserir(conexao, transacao, lar);

                        transacao.Commit();

                        lock (bloqueio)
                        {
                            foreach (LarTemporario lar in lote)
                                cache.Remove(lar);
                        }
                    }
                    catch
                    {
                        transacao.Rollback();
                        throw;
                    }
                }
            }
        }

        internal static void SincronizarComAviso()
        {
            try
            {
                Sincronizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de lares",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static void Inserir(MySqlConnection conexao, MySqlTransaction transacao, LarTemporario lar)
        {
            int idTipoMoradia = RepositorioGatos.ObterId(conexao, transacao,
                "SELECT id_tipo_moradia FROM tipo_moradia WHERE descricao = @descricao",
                lar.TipoMoradia);

            int idCapacidade = RepositorioGatos.ObterId(conexao, transacao,
                "SELECT id_capacidade FROM capacidade_lar WHERE descricao = @descricao",
                lar.Capacidade);

            int idOutros = RepositorioGatos.ObterId(conexao, transacao,
                "SELECT id_opcao FROM opcao_outros_animais WHERE descricao = @descricao",
                lar.OutrosAnimais);

            int idDisponibilidade = RepositorioGatos.ObterId(conexao, transacao,
                "SELECT id_disponibilidade FROM disponibilidade_lar WHERE descricao = @descricao",
                lar.Disponibilidade);

            // 1. endereço
            int idEndereco;
            string sqlEndereco = @"
                INSERT INTO endereco (cep, cidade, estado, logradouro, bairro, numero)
                VALUES (@cep, @cidade, @estado, @logradouro, @bairro, @numero);";

            using (MySqlCommand comando = new MySqlCommand(sqlEndereco, conexao, transacao))
            {
                comando.Parameters.AddWithValue("@cep", lar.Cep);
                comando.Parameters.AddWithValue("@cidade", lar.Cidade);
                comando.Parameters.AddWithValue("@estado", lar.Estado);
                comando.Parameters.AddWithValue("@logradouro", lar.Logradouro);
                comando.Parameters.AddWithValue("@bairro", lar.Bairro);
                comando.Parameters.AddWithValue("@numero", lar.Numero);
                comando.ExecuteNonQuery();
                idEndereco = Convert.ToInt32(comando.LastInsertedId);
            }

            // 2. lar temporário
            string sql = @"
                INSERT INTO lar_temporario
                (nome_completo, cpf, telefone, email, id_endereco, id_tipo_moradia,
                 id_capacidade, id_outros_animais, id_disponibilidade,
                 inicio_disponivel, observacoes_ambiente_rotina)
                VALUES
                (@nome, @cpf, @telefone, @email, @idEndereco, @idTipoMoradia,
                 @idCapacidade, @idOutros, @idDisponibilidade,
                 @inicioDisponivel, @observacoes);";

            using (MySqlCommand comando = new MySqlCommand(sql, conexao, transacao))
            {
                comando.Parameters.AddWithValue("@nome", lar.NomeCompleto);
                comando.Parameters.AddWithValue("@cpf", lar.Cpf);
                comando.Parameters.AddWithValue("@telefone", lar.Telefone);
                comando.Parameters.AddWithValue("@email", lar.Email);
                comando.Parameters.AddWithValue("@idEndereco", idEndereco);
                comando.Parameters.AddWithValue("@idTipoMoradia", idTipoMoradia);
                comando.Parameters.AddWithValue("@idCapacidade", idCapacidade);
                comando.Parameters.AddWithValue("@idOutros", idOutros);
                comando.Parameters.AddWithValue("@idDisponibilidade", idDisponibilidade);
                comando.Parameters.AddWithValue("@inicioDisponivel", lar.InicioDisponivel.Date);
                comando.Parameters.AddWithValue("@observacoes",
                    string.IsNullOrWhiteSpace(lar.Observacoes) ? (object)DBNull.Value : lar.Observacoes);
                comando.ExecuteNonQuery();
            }
        }

        public static int ObterVagasDisponiveis()
        {
            SincronizarComAviso();

            string sql = @"
        SELECT cap.descricao AS capacidade, COUNT(g.id_gato) AS ocupados
        FROM lar_temporario l
        INNER JOIN capacidade_lar cap ON l.id_capacidade = cap.id_capacidade
        INNER JOIN disponibilidade_lar d ON l.id_disponibilidade = d.id_disponibilidade
        LEFT JOIN gato g ON g.id_lar_temporario = l.id_lar_temporario
            AND g.id_status IN (SELECT id_status FROM status_gato WHERE descricao <> 'Adotado')
        WHERE d.descricao = 'Disponível'
        GROUP BY l.id_lar_temporario, cap.descricao;";

            int total = 0;

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        Match numero = Regex.Match(Convert.ToString(leitor["capacidade"]), @"\d+");
                        int capacidade = numero.Success ? int.Parse(numero.Value) : 0;
                        int ocupados = Convert.ToInt32(leitor["ocupados"]);

                        total += Math.Max(0, capacidade - ocupados);
                    }
                }
            }

            return total;
        }

        public static List<LarTemporario> ObterTodosCompletos()
        {
            SincronizarComAviso();

            List<LarTemporario> lista = new List<LarTemporario>();

            string sql = @"
                SELECT l.id_lar_temporario, l.nome_completo, l.cpf, l.telefone, l.email,
                        tm.descricao AS tipo_moradia, cap.descricao AS capacidade,
                        oa.descricao AS outros_animais, d.descricao AS disponibilidade,
                        l.inicio_disponivel, l.observacoes_ambiente_rotina
                FROM lar_temporario l
                INNER JOIN tipo_moradia tm ON l.id_tipo_moradia = tm.id_tipo_moradia
                INNER JOIN capacidade_lar cap ON l.id_capacidade = cap.id_capacidade
                INNER JOIN opcao_outros_animais oa ON l.id_outros_animais = oa.id_opcao
                INNER JOIN disponibilidade_lar d ON l.id_disponibilidade = d.id_disponibilidade
                ORDER BY l.nome_completo;";

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        lista.Add(new LarTemporario
                        {
                            Id = Convert.ToInt32(leitor["id_lar_temporario"]),
                            NomeCompleto = Convert.ToString(leitor["nome_completo"]),
                            Cpf = Convert.ToString(leitor["cpf"]),
                            Telefone = Convert.ToString(leitor["telefone"]),
                            Email = Convert.ToString(leitor["email"]),
                            TipoMoradia = Convert.ToString(leitor["tipo_moradia"]),
                            Capacidade = Convert.ToString(leitor["capacidade"]),
                            OutrosAnimais = Convert.ToString(leitor["outros_animais"]),
                            Disponibilidade = Convert.ToString(leitor["disponibilidade"]),
                            InicioDisponivel = Convert.ToDateTime(leitor["inicio_disponivel"]),
                            Observacoes = leitor["observacoes_ambiente_rotina"] == DBNull.Value
                                ? null
                                : Convert.ToString(leitor["observacoes_ambiente_rotina"])
                        });
                    }
                }
            }

            return lista;
        }

        public static List<LarTemporarioCombo> ObterTodos()
        {
            // grava os lares pendentes antes, para que apareçam no combo
            SincronizarComAviso();

            List<LarTemporarioCombo> lares = new List<LarTemporarioCombo>();

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                string sql = @"
                    SELECT id_lar_temporario, nome_completo
                    FROM lar_temporario
                    ORDER BY nome_completo;";

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lares.Add(new LarTemporarioCombo
                        {
                            Id = Convert.ToInt32(reader["id_lar_temporario"]),
                            Nome = reader["nome_completo"].ToString()
                        });
                    }
                }
            }

            return lares;
        }
    }
}