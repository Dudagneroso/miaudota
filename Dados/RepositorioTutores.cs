using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace miaudota
{
    internal class RepositorioTutores
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
        private static List<Tutor> pendentesInserir = new List<Tutor>();
        private const int LIMITE = 5;

        static RepositorioTutores()
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
            /*
            if (tutores == null)
            {
                tutores = LerDoBanco();
            }
            */
            return tutores;
        }


        public static void Adicionar(Tutor tutor)
        {
            tutores.Add(tutor);
            pendentesInserir.Add(tutor);

            if (pendentesInserir.Count >= LIMITE)
            {
                Sincronizar();
            }
        }

        public static void Sincronizar()
        {
            foreach (Tutor t in pendentesInserir.ToList())
            {
                pendentesInserir.Remove(t);
            }
        }

        public static void Excluir(Tutor tutor)
        {
            tutores.Remove(tutor);
        }

        public static void Atualizar(Tutor tutor)
        {
            var tutorExistente = tutores.FirstOrDefault(t => t.CPF == tutor.CPF);
            if (tutorExistente != null)
            {
                tutorExistente.Nome = tutor.Nome;
                tutorExistente.DataNascimento = tutor.DataNascimento;
                tutorExistente.Email = tutor.Email;
                tutorExistente.Telefone = tutor.Telefone;
                tutorExistente.CEP = tutor.CEP;
                tutorExistente.Cidade = tutor.Cidade;
                tutorExistente.Estado = tutor.Estado;
                tutorExistente.Logradouro = tutor.Logradouro;
                tutorExistente.Bairro = tutor.Bairro;
                tutorExistente.Numero = tutor.Numero;
                tutorExistente.TipoResidencia = tutor.TipoResidencia;
                tutorExistente.OutrosAnimais = tutor.OutrosAnimais;
                
            }
        }
    }
              
}
