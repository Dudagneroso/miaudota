using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace miaudota
{
    internal class RepositorioGatos
    {
        private static List<Gato> cache = new List<Gato>();

        //objeto para controlar o acesso ao cache
        private static readonly object bloqueio = new object();

        private const int LIMITE_CACHE = 5;

        // retorna quantos gatos estão aguardando o envio para o banco
        public static int QuantidadePendente()
        {
            lock (bloqueio)
            {
                return cache.Count;
            }
        }

        public static void Adicionar(Gato gato)
        {
            if (gato == null)
            {
                throw new ArgumentNullException(nameof(gato));
            }

            bool sincronizar;

            lock (bloqueio)
            {
                // Evita adicionar o mesmo microchip duas vezes ao cache.
                if (!string.IsNullOrWhiteSpace(gato.NumeroMicrochip) &&
                    cache.Any(g => g.NumeroMicrochip == gato.NumeroMicrochip))
                {
                    throw new InvalidOperationException(
                        "Já existe um gato com esse microchip aguardando sincronização.");
                }

                cache.Add(gato);
                sincronizar = cache.Count >= LIMITE_CACHE;
            }

            if (sincronizar)
            {
                Sincronizar();
            }
        }

        public static void Sincronizar()
        {
            List<Gato> lote;

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
                        foreach (Gato gato in lote)
                        {
                            InserirGato(conexao, transacao, gato);
                        }

                        transacao.Commit();

                        lock (bloqueio)
                        {
                            foreach (Gato gato in lote)
                            {
                                cache.Remove(gato);
                            }
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

        private static void InserirGato(MySqlConnection conexao, MySqlTransaction transacao, Gato gato)
        {
            int idPelagem = ObterId(conexao, transacao, "SELECT id_pelagem FROM pelagem WHERE descricao = @descricao", gato.Pelagem);

            int idColoracao = ObterId(
                conexao, transacao,
                "SELECT id_coloracao FROM coloracao WHERE descricao = @descricao",
                gato.Coloracao);

            int idStatus = ObterId(
                conexao, transacao,
                "SELECT id_status FROM status_gato WHERE descricao = @descricao",
                gato.Status);

            int idFiv = ObterId(
                conexao, transacao,
                "SELECT id_resultado FROM resultado_teste WHERE descricao = @descricao",
                gato.TesteFIV);

            int idFelv = ObterId(
                conexao, transacao,
                "SELECT id_resultado FROM resultado_teste WHERE descricao = @descricao",
                gato.TesteFelv);

            string sql = @"
                INSERT INTO gato
                (
                    microchip,
                    nome,
                    data_nascimento,
                    sexo,
                    id_pelagem,
                    id_coloracao,
                    peso_kg,
                    id_lar_temporario,
                    castrado,
                    vacinas_em_dia,
                    id_status,
                    id_teste_fiv,
                    id_teste_felv,
                    doenca_deficiencia,
                    observacoes,
                    data_entrada,
                    foto
                )
                VALUES
                (
                    @microchip,
                    @nome,
                    @dataNascimento,
                    @sexo,
                    @idPelagem,
                    @idColoracao,
                    @peso,
                    @idLar,
                    @castrado,
                    @vacinasEmDia,
                    @idStatus,
                    @idFiv,
                    @idFelv,
                    @doencas,
                    @observacoes,
                    @dataEntrada,
                    @foto
                );";

            int idGato;

            using (MySqlCommand comando = new MySqlCommand(sql,conexao, transacao))
            {
                comando.Parameters.AddWithValue("@microchip",
                    string.IsNullOrWhiteSpace(gato.NumeroMicrochip)
                    ? (object)DBNull.Value : gato.NumeroMicrochip);

                comando.Parameters.AddWithValue("@nome", gato.Nome);
                comando.Parameters.AddWithValue("@dataNascimento", gato.DataNascimento.Date);
                comando.Parameters.AddWithValue("@sexo", gato.Sexo);
                comando.Parameters.AddWithValue("@idPelagem", idPelagem);
                comando.Parameters.AddWithValue("@idColoracao", idColoracao);

                comando.Parameters.AddWithValue("@peso",
                    gato.Peso > 0
                    ? (object)Convert.ToDecimal(gato.Peso)
                    : DBNull.Value);

                comando.Parameters.AddWithValue("@idLar",
                    gato.IdLarTemporario.HasValue
                    ? (object)gato.IdLarTemporario.Value
                    : DBNull.Value);

                comando.Parameters.AddWithValue("@castrado",
                    gato.Castrado == "Sim");

                comando.Parameters.AddWithValue("@vacinasEmDia",
                    gato.VacinasEmDia == "Sim");

                comando.Parameters.AddWithValue("@idStatus", idStatus);
                comando.Parameters.AddWithValue("@idFiv", idFiv);
                comando.Parameters.AddWithValue("@idFelv", idFelv);

                comando.Parameters.AddWithValue("@doencas",
                    string.IsNullOrWhiteSpace(gato.Doencas)
                    ? (object)DBNull.Value : gato.Doencas);

                comando.Parameters.AddWithValue("@observacoes",
                    string.IsNullOrWhiteSpace(gato.Observacoes)
                    ? (object)DBNull.Value : gato.Observacoes);

                comando.Parameters.AddWithValue("@dataEntrada", gato.DataChegadaOng.Date);

                comando.Parameters.AddWithValue("@foto",
                    string.IsNullOrWhiteSpace(gato.CaminhoFoto)
                    ? (object)DBNull.Value : gato.CaminhoFoto);

                comando.ExecuteNonQuery();

                idGato = Convert.ToInt32(comando.LastInsertedId);
            }

            // Inserir as vacinas selecionadas.
            foreach (string nomeVacina in gato.Vacinas.Distinct())
            {
                int idVacina = ObterId(
                    conexao,
                    transacao,
                    "SELECT id_vacina FROM vacina WHERE nome = @descricao",
                    nomeVacina);

                string sqlVacina = @"
                    INSERT INTO gato_vacina (id_gato, id_vacina)
                    VALUES (@idGato, @idVacina);";

                using (MySqlCommand comandoVacina =
                    new MySqlCommand(sqlVacina, conexao, transacao))
                {
                    comandoVacina.Parameters.AddWithValue("@idGato", idGato);
                    comandoVacina.Parameters.AddWithValue("@idVacina", idVacina);
                    comandoVacina.ExecuteNonQuery();
                }
            }

            // Inserir o local de resgate, quando informado.
            if (gato.Latitude.HasValue && gato.Longitude.HasValue)
            {
                string sqlLocal = @"
                    INSERT INTO local_resgate
                    (id_gato, latitude, longitude)
                    VALUES
                    (@idGato, @latitude, @longitude);";

                using (MySqlCommand comandoLocal =
                    new MySqlCommand(sqlLocal, conexao, transacao))
                {
                    comandoLocal.Parameters.AddWithValue("@idGato", idGato);
                    comandoLocal.Parameters.AddWithValue("@latitude", gato.Latitude.Value);
                    comandoLocal.Parameters.AddWithValue("@longitude", gato.Longitude.Value);

                    comandoLocal.ExecuteNonQuery();
                }
            }
            else if (gato.Latitude.HasValue || gato.Longitude.HasValue)
            {
                throw new InvalidOperationException(
                    "A latitude e a longitude do local de resgate devem ser informadas juntas.");
            }
        }

        private static int ObterId(
            MySqlConnection conexao,
            MySqlTransaction transacao,
            string sql,
            string descricao)
        {
            using (MySqlCommand comando = new MySqlCommand(sql, conexao, transacao))
            {
                comando.Parameters.AddWithValue("@descricao", descricao);

                object resultado = comando.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                {
                    throw new InvalidOperationException(
                        "Não foi encontrado no banco o cadastro: " + descricao);
                }

                return Convert.ToInt32(resultado);
            }
        }
    }
}
