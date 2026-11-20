using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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