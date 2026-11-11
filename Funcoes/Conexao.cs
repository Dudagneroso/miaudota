using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace miaudota
{
    internal class Conexao
    {
        public static MySqlConnection Obter()
        {
            string caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "miaudota_conexao.txt");

            string texto = File.ReadAllText(caminho).Trim();
            return new MySqlConnection(texto);
        }

        public static void Testar()
        {
            using(MySqlConnection conexao = Obter())
            {
                conexao.Open();
            }
        }
    }
}
