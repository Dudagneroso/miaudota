using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    public class OcorrenciaGato
    {
        private string numeroMicrochip;
        private string tipo;
        private DateTime data;
        private string local;
        private string responsavel;
        private string descricao;

        public OcorrenciaGato()
        {
        }

        public OcorrenciaGato(string numeroMicrochip, string tipo, DateTime data, string local, string responsavel, string descricao)
        {
            this.numeroMicrochip = numeroMicrochip;
            this.tipo = tipo;
            this.data = data;
            this.local = local;
            this.responsavel = responsavel;
            this.descricao = descricao;
        }

        public string NumeroMicrochip
        {
            get { return numeroMicrochip; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Digite o número do microchip.");
                }
                numeroMicrochip = value; 
            }
        }
        public string Tipo
        {
            get { return tipo; }
            set 
            {
                tipo = value; 
            }
        }
        public DateTime Data
        {
            get { return data; }
            set 
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("A data da ocorrência não pode ser futura.");
                }
                data = value; 
            }
        }
        public string Local
        {
            get { return local; }
            set { local = value; }
        }
        public string Responsavel
        {
            get { return responsavel; }
            set { responsavel = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
