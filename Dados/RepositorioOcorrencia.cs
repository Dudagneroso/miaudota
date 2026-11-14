using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miaudota
{
    internal class RepositorioOcorrencia
    {
        private static List<OcorrenciaGato> cache = new List<OcorrenciaGato>();
        private static readonly object bloqueio = new object();
        private const int LIMITE_CACHE = 5;

        public static void Adicionar(OcorrenciaGato ocorrencia)
        {
            if (ocorrencia == null)
            {
                throw new ArgumentNullException(nameof(ocorrencia));
            }

            bool sincronizar;

            lock (bloqueio)
            {
                cache.Add(ocorrencia);
                sincronizar = cache.Count >= LIMITE_CACHE;
            }

            if (sincronizar)
            {
                SincronizarComAviso();
            }
        }

        public static void Sincronizar()
        {
            List<OcorrenciaGato> lote;

            lock (bloqueio)
            {
                if (cache.Count == 0)
                    return;

                lote = cache.ToList();
            }

            // gatos pendentes no cache precisam estar no banco antes das ocorrências deles
            RepositorioGatos.SincronizarComAviso();

            List<string> erros = new List<string>();

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                foreach (OcorrenciaGato ocorrencia in lote)
                {
                    try
                    {
                        InserirOcorrencia(conexao, ocorrencia);
                    }
                    catch (Exception ex)
                    {
                        erros.Add(ocorrencia.NumeroMicrochip + " (" + ocorrencia.Tipo + "): " + ex.Message);
                    }

                    // sai do cache com sucesso ou erro, para não travar as próximas sincronizações
                    lock (bloqueio)
                    {
                        cache.Remove(ocorrencia);
                    }
                }
            }

            if (erros.Count > 0)
            {
                throw new InvalidOperationException(
                    "Algumas ocorrências não puderam ser salvas:\n" + string.Join("\n", erros));
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
                MessageBox.Show(ex.Message, "Ocorrências", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static void InserirOcorrencia(MySqlConnection conexao, OcorrenciaGato ocorrencia)
        {
            int idGato;
            using (MySqlCommand comando = new MySqlCommand(
                "SELECT id_gato FROM gato WHERE microchip = @microchip LIMIT 1;", conexao))
            {
                comando.Parameters.AddWithValue("@microchip", ocorrencia.NumeroMicrochip);

                object resultado = comando.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                {
                    throw new InvalidOperationException("Não existe gato cadastrado com esse microchip.");
                }

                idGato = Convert.ToInt32(resultado);
            }

            int idTipo = RepositorioGatos.ObterId(
                conexao, null,
                "SELECT id_tipo_ocorrencia FROM tipo_ocorrencia WHERE nome = @descricao",
                ocorrencia.Tipo);

            string sql = @"
        INSERT INTO ocorrencia
        (id_gato, id_tipo_ocorrencia, data_ocorrencia, local,
         responsavel_registro, motivo)
        VALUES
        (@idGato, @idTipo, @data, @local, @responsavel, @motivo);";

            using (MySqlCommand comando = new MySqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@idGato", idGato);
                comando.Parameters.AddWithValue("@idTipo", idTipo);
                comando.Parameters.AddWithValue("@data", ocorrencia.Data.Date);

                comando.Parameters.AddWithValue("@local",
                    string.IsNullOrWhiteSpace(ocorrencia.Local)
                    ? (object)DBNull.Value : ocorrencia.Local.Trim());

                comando.Parameters.AddWithValue("@responsavel", ocorrencia.Responsavel.Trim());

                comando.Parameters.AddWithValue("@motivo",
                    string.IsNullOrWhiteSpace(ocorrencia.Descricao)
                    ? (object)DBNull.Value : ocorrencia.Descricao.Trim());

                comando.ExecuteNonQuery();
            }
        }

        public static List<OcorrenciaGato> ObterPorGato(string microchip)
        {
            SincronizarComAviso();
            List<OcorrenciaGato> lista = new List<OcorrenciaGato>();

            string sql = @"
                SELECT g.microchip, t.nome AS tipo, o.data_ocorrencia, o.local, o.responsavel_registro, o.motivo
                FROM ocorrencia o
                INNER JOIN gato g ON o.id_gato = g.id_gato
                INNER JOIN tipo_ocorrencia t ON o.id_tipo_ocorrencia = t.id_tipo_ocorrencia
                WHERE g.microchip = @microchip
                ORDER BY o.data_ocorrencia DESC, o.id_ocorrencia DESC;";

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@microchip", microchip);

                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            OcorrenciaGato ocorrencia = new OcorrenciaGato();
                            ocorrencia.NumeroMicrochip = Convert.ToString(leitor["microchip"]);
                            ocorrencia.Tipo = Convert.ToString(leitor["tipo"]);
                            ocorrencia.Data = Convert.ToDateTime(leitor["data_ocorrencia"]);
                            ocorrencia.Responsavel = Convert.ToString(leitor["responsavel_registro"]);

                            if (leitor["local"] != DBNull.Value)
                                ocorrencia.Local = Convert.ToString(leitor["local"]);

                            if (leitor["motivo"] != DBNull.Value)
                                ocorrencia.Descricao = Convert.ToString(leitor["motivo"]);

                            lista.Add(ocorrencia);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
