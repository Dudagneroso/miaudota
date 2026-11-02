using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    internal class RepositorioGatosFake
    {
        /* public static List<Gato> ObterTodos()
                
                //new Gato { Nome = "Amora", NumeroMicrochip = "009", Idade = 1, Sexo = "Fêmea", Pelagem = "Rajada", DataCadastro = DateTime.Now, DataChegadaOng =
    
        */

        private static readonly List<Gato> gatos = new List<Gato>
        {
            new Gato { Nome = "Mia", NumeroMicrochip = "001", DataNascimento = new DateTime(2025, 4, 3), Sexo = "Fêmea", Coloracao = "Preta", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 3, 10) },
            new Gato { Nome = "Tom", NumeroMicrochip = "002", DataNascimento = new DateTime(2025, 1, 1), Sexo = "Macho", Coloracao = "Laranja", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 6, 20) },
            new Gato { Nome = "Mingau", NumeroMicrochip = "003", DataNascimento = new DateTime(2024, 1, 1), Sexo = "Macho", Coloracao = "Branca", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 7, 20) },
            new Gato { Nome = "Lily", NumeroMicrochip = "004", DataNascimento = new DateTime(2024, 1, 1), Sexo = "Fêmea", Coloracao = "Cinza", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 8, 15) },
            new Gato { Nome = "Nina", NumeroMicrochip = "005", DataNascimento = new DateTime(2024, 1, 1), Sexo = "Fêmea", Coloracao = "Branca", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2024, 11, 5) },
            new Gato { Nome = "Simba", NumeroMicrochip = "006", DataNascimento = new DateTime(2025, 1, 1), Sexo = "Macho", Coloracao = "Cinza", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 8, 1) },
            new Gato { Nome = "Luna", NumeroMicrochip = "007", DataNascimento = new DateTime(2023, 1, 1), Sexo = "Fêmea", Coloracao = "Malhada", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2023, 2, 14) },
            new Gato { Nome = "Bento", NumeroMicrochip = "008", DataNascimento = new DateTime(2025, 1, 1), Sexo = "Macho", Coloracao = "Preta e Branca", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 1, 30) },
        };

        public static List<Gato> ObterTodos()
        {
            return gatos;
        }

        public static void Adicionar(Gato gato)
        {
            gatos.Add(gato);
        }
    }
}
