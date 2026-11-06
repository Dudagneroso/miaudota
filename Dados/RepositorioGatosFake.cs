using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    internal class RepositorioGatosFake
    {

        private static readonly List<Gato> gatos = new List<Gato>
        {
            new Gato { Nome = "Mia", NumeroMicrochip = "001", DataNascimento = new DateTime(2025, 4, 3), Sexo = "Fêmea", Coloracao = "Preta", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2026, 10, 01), Status = "Adotado", Data_Adocao = new DateTime(2026, 10, 30) },
            new Gato { Nome = "Tom", NumeroMicrochip = "002", DataNascimento = new DateTime(2025, 1, 1), Sexo = "Macho", Coloracao = "Vermelha/Laranja", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 6, 20), Status = "Adotado", Data_Adocao = new DateTime(2026, 10, 20) },
            new Gato { Nome = "Mingau", NumeroMicrochip = "003", DataNascimento = new DateTime(2024, 1, 1), Sexo = "Macho", Coloracao = "Branca", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 7, 20), Status = "Adotado", Data_Adocao = new DateTime(2026, 10, 03) },
            new Gato { Nome = "Lily", NumeroMicrochip = "004", DataNascimento = new DateTime(2024, 1, 1), Sexo = "Fêmea", Coloracao = "Cinza", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 8, 15), Status = "Disponível" },
            new Gato { Nome = "Nina", NumeroMicrochip = "005", DataNascimento = new DateTime(2024, 1, 1), Sexo = "Fêmea", Coloracao = "Branca", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2024, 11, 5), Status = "Disponível" },
            new Gato { Nome = "Simba", NumeroMicrochip = "006", DataNascimento = new DateTime(2025, 1, 1), Sexo = "Macho", Coloracao = "Cinza", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 8, 1), Status = "Disponível" },
            new Gato { Nome = "Luna", NumeroMicrochip = "007", DataNascimento = new DateTime(2023, 1, 1), Sexo = "Fêmea", Coloracao = "Tigrada", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2023, 2, 14), Status = "Disponível" },
            new Gato { Nome = "Bento", NumeroMicrochip = "008", DataNascimento = new DateTime(2025, 1, 1), Sexo = "Macho", Coloracao = "Bicolor", DataCadastro = DateTime.Now, DataChegadaOng = new DateTime(2025, 1, 30), Status = "Disponível" },
            new Gato { Nome = "Amora", NumeroMicrochip = "009", DataNascimento = new DateTime(2024, 3, 15), Sexo = "Fêmea", Pelagem = "Curta", Coloracao = "Preta", LarTemporario = "Ana", Castrado = "Sim", VacinasEmDia = "Sim", Status = "Disponível", TesteFIV = "Negativo", TesteFelv = "Negativo", Doencas = "Nenhuma", Observacoes = "Resgatada próxima a uma praça", DataChegadaOng = new DateTime(2026, 5, 10), CaminhoFoto = "", LocalResgate = "Sim", Latitude = -22.9056, Longitude = -47.0608, DataCadastro = new DateTime(2026, 5, 10) },
            new Gato { Nome = "Pipoca", NumeroMicrochip = "010", DataNascimento = new DateTime(2025, 1, 20), Sexo = "Fêmea", Pelagem = "Longa", Coloracao = "Bicolor", LarTemporario = "Maria", Castrado = "Não", VacinasEmDia = "Sim", Status = "Disponível", TesteFIV = "Negativo", TesteFelv = "Negativo", Doencas = "Nenhuma", Observacoes = "Resgatada em uma residência abandonada", DataChegadaOng = new DateTime(2026, 5, 15), CaminhoFoto = "", LocalResgate = "Sim", Latitude = -22.9058, Longitude = -47.0610, DataCadastro = new DateTime(2026, 5, 15) },
            new Gato { Nome = "Thor", NumeroMicrochip = "011", DataNascimento = new DateTime(2022, 7, 8), Sexo = "Macho", Pelagem = "Curta", Coloracao = "Laranja e branco", LarTemporario = "Carlos", Castrado = "Sim", VacinasEmDia = "Sim", Status = "Disponível", TesteFIV = "Negativo", TesteFelv = "Negativo", Doencas = "Nenhuma", Observacoes = "Resgatado próximo a uma avenida", DataChegadaOng = new DateTime(2026, 6, 2), CaminhoFoto = "", LocalResgate = "Sim", Latitude = -22.9120, Longitude = -47.0650, DataCadastro = new DateTime(2026, 6, 2) },
            new Gato { Nome = "Mel", NumeroMicrochip = "012", DataNascimento = new DateTime(2023, 9, 12), Sexo = "Fêmea", Pelagem = "Curta", Coloracao = "Caramelo", LarTemporario = "Juliana", Castrado = "Sim", VacinasEmDia = "Sim", Status = "Disponível", TesteFIV = "Negativo", TesteFelv = "Negativo", Doencas = "Nenhuma", Observacoes = "Resgatada em uma região residencial", DataChegadaOng = new DateTime(2026, 6, 8), CaminhoFoto = "", LocalResgate = "Sim", Latitude = -22.9080, Longitude = -47.0630, DataCadastro = new DateTime(2026, 6, 8) }
        };

        public static List<Gato> ObterTodos()
        {
            return gatos.ToList();
        }

        public static void Adicionar(Gato gato)
        {
            gatos.Add(gato);
        }
    }
}
