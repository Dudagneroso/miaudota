using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    internal class RepositorioTutoresFake
    {
        public static List<Tutor> ObterTodos()
        {
            List<Gato> gatos = RepositorioGatosFake.ObterTodos();

            return new List<Tutor>
            {
                new Tutor { Nome = "Ana", CPF = "12345678901", DataNascimento = new DateTime(1990, 5, 15), Email = "ana@email.com", Telefone = "11987654321", Endereco = "Rua A, 100", Gatos = new List<Gato> { gatos[0], gatos[2], gatos[4] } },
                new Tutor { Nome = "Carlos", CPF = "12345678902", DataNascimento = new DateTime(1985, 8, 20), Email = "carlos@email.com", Telefone = "11987654322", Endereco = "Rua B, 200" },
                new Tutor { Nome = "Bruna", CPF = "12345678903", DataNascimento = new DateTime(1999, 9, 21), Email = "bruna@email.com", Telefone = "11987654323", Endereco = "Rua C, 300" },
            };
        }
    }
              
}
