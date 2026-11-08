using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    public class Ocorrencia
    {
        private string sigla;
        private string nome;
        private string descricao;

        public Ocorrencia()
        {
        }

        public Ocorrencia(string sigla, string nome, string descricao)
        {
            this.sigla = sigla;
            this.nome = nome;
            this.descricao = descricao;
        }

        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
