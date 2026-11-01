using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    internal class TiposOcorrencia
    {
        public static List<Ocorrencia> ObterTodos()
        {
            return new List<Ocorrencia>
            {
                new Ocorrencia { Sigla = "DV", Nome = "Devolução", Descricao = "Devolvido pelo tutor"},
                new Ocorrencia { Sigla = "AB", Nome = "Abandono", Descricao = "encontrado abandonado"},
                new Ocorrencia { Sigla = "FG", Nome = "Fuga", Descricao = "Animal desaparecido"},
                new Ocorrencia { Sigla = "RL", Nome = "Retorno ao Lar", Descricao = "Retornou à ONG ou ao lar"},
                new Ocorrencia { Sigla = "IN", Nome = "Internação", Descricao = "Cuidados vaterinários"},
                new Ocorrencia { Sigla = "OB", Nome = "Óbito", Descricao = "Registro de falecimento"}
            };
        }
    }
}
