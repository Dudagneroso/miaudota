using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static List<LarTemporarioCombo> ObterTodos()
        {
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
