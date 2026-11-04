using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    internal class RepositorioTutoresFake
    {
        /*public static List<Tutor> ObterTodos()
        {
            List<Gato> gatos = RepositorioGatosFake.ObterTodos();

            return new List<Tutor>
            {
                new Tutor { Nome = "Ana", CPF = "12345678901", DataNascimento = new DateTime(1990, 5, 15), Email = "ana@email.com", Telefone = "11987654321", Endereco = "Rua A, 100", Gatos = new List<Gato> { gatos[0] } },
                new Tutor { Nome = "Carlos", CPF = "12345678902", DataNascimento = new DateTime(1985, 8, 20), Email = "carlos@email.com", Telefone = "11987654322", Endereco = "Rua B, 200" },
                new Tutor { Nome = "Bruna", CPF = "12345678903", DataNascimento = new DateTime(1999, 9, 21), Email = "bruna@email.com", Telefone = "11987654323", Endereco = "Rua C, 300" },
            };
        }*/
        private static readonly List<Gato> gatos;
        private static readonly List<Tutor> tutores;

        static RepositorioTutoresFake()
        {
            gatos = RepositorioGatosFake.ObterTodos();
            tutores = new List<Tutor>
            {
                new Tutor { Nome = "Ana", CPF = "12345678901", DataNascimento = new DateTime(1990, 5, 15), Email = "ana@email.com", Telefone = "11987654321", CEP = "12345-678", Cidade = "São Paulo", Estado = "SP", Logradouro = "Rua A", Bairro = "Centro", Numero = 100, TipoResidencia = "Apartamento", OutrosAnimais = "Não", Gatos = new List<Gato> { gatos[0] } },
                new Tutor { Nome = "Carlos", CPF = "12345678902", DataNascimento = new DateTime(1985, 8, 20), Email = "carlos@email.com", Telefone = "11987654322", CEP = "12345-679", Cidade = "São Paulo", Estado = "SP", Logradouro = "Rua B", Bairro = "Jardim", Numero = 200, TipoResidencia = "Casa com quintal", OutrosAnimais = "Sim - cachorro(s)", Gatos = new List<Gato> { gatos[1] } },
                new Tutor { Nome = "Bruna", CPF = "12345678903", DataNascimento = new DateTime(1999, 9, 21), Email = "bruna@email.com", Telefone = "11987654323", CEP = "12345-680", Cidade = "São Paulo", Estado = "SP", Logradouro = "Rua C", Bairro = "Vila Madalena", Numero = 300, TipoResidencia = "Apartamento", OutrosAnimais = "Sim - gato(s)", Gatos = new List<Gato> { gatos[2] } },
            };
        }

        public static List<Tutor> ObterTodos()
        {
            return tutores;
        }

        public static void Adicionar(Tutor tutor)
        {
            tutores.Add(tutor);
        }

        public static void Excluir(Tutor tutor)
        {
            tutores.Remove(tutor);
        }

    }
              
}
