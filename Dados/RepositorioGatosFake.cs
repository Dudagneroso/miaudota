using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    internal class RepositorioGatosFake
    {
        public static List<Gato> ObterTodos()
        {
            return new List<Gato>
            {
                new Gato { Nome = "Mia", NumeroMicrochip = "001", Idade = 2, Sexo = "Fêmea", Pelagem = "Preta", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 3, 10) },
                new Gato { Nome = "Tom", NumeroMicrochip = "002", Idade = 1, Sexo = "Macho", Pelagem = "Laranja", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 6, 20) },
                new Gato { Nome = "Mingau", NumeroMicrochip = "003", Idade = 4, Sexo = "Macho", Pelagem = "Branca", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 7, 20) },
                new Gato { Nome = "Lily", NumeroMicrochip = "004", Idade = 3, Sexo = "Fêmea", Pelagem = "Cinza", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 8, 15) },
                new Gato { Nome = "Nina", NumeroMicrochip = "005", Idade = 3, Sexo = "Fêmea", Pelagem = "Branca", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2024, 11, 5) },
                new Gato { Nome = "Simba", NumeroMicrochip = "006", Idade = 1, Sexo = "Macho", Pelagem = "Cinza", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 8, 1) },
                new Gato { Nome = "Luna", NumeroMicrochip = "007", Idade = 4, Sexo = "Fêmea", Pelagem = "Malhada", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2023, 2, 14) },
                new Gato { Nome = "Bento", NumeroMicrochip = "008", Idade = 2, Sexo = "Macho", Pelagem = "Preta e Branca", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 1, 30) },
                new Gato { Nome = "Amora", NumeroMicrochip = "009", Idade = 1, Sexo = "Fêmea", Pelagem = "Rajada", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 9, 10) },
            };
        }
    }
}
