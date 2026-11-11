using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    public class Gato
    {
        private string numeroMicrochip;
        private string nome;
        private DateTime dataNascimento;
        private string sexo;
        private string pelagem;
        private string coloracao;
        private float peso;
        private string larTemporario;
        private string castrado;
        private string vacinasEmDia;
        private List<string> vacinas = new List<string>();
        private string status;
        private string testeFIV;
        private string testeFelv;
        private string doencas;
        private string observacoes;
        private DateTime dataChegadaOng;
        private string caminhoFoto;
        private string localResgate;
        private double? latitude;
        private double? longitude;
        private DateTime dataCadastro;
        private DateTime dataAdocao;

        public Gato()
        {
        }

        public Gato(string numeroMicrochip, string nome, DateTime dataNascimento, string sexo, string pelagem, string coloracao, float peso, string larTemporario, string castrado, string vacinasEmDia, List<string> vacinas, string status, string testeFIV, string testeFelv, string doencas, string observacoes, DateTime dataChegadaOng, string caminhoFoto, string localResgate, double? latitude, double? longitude, DateTime dataCadastro, DateTime dataAdocao)
        {
            this.numeroMicrochip = numeroMicrochip;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;
            this.pelagem = pelagem;
            this.coloracao = coloracao;
            this.peso = peso;
            this.larTemporario = larTemporario;
            this.castrado = castrado;
            this.vacinasEmDia = vacinasEmDia;
            this.vacinas = vacinas;
            this.status = status;
            this.testeFIV = testeFIV;
            this.testeFelv = testeFelv;
            this.doencas = doencas;
            this.observacoes = observacoes;
            this.dataChegadaOng = dataChegadaOng;
            this.caminhoFoto = caminhoFoto;
            this.localResgate = localResgate;
            this.latitude = latitude;
            this.longitude = longitude;
            this.dataCadastro = dataCadastro;
            this.dataAdocao = dataAdocao;
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

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Digite o nome.");
                }
                nome = value;
            }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("A data de nascimento não pode ser futura.");
                }
                dataNascimento = value;
            }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Pelagem
        {
            get { return pelagem; }
            set { pelagem = value; }
        }
        public string Coloracao
        {
            get { return coloracao; }
            set { coloracao = value; }
        }

        public float Peso
        {
            get { return peso; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("O peso deve ser maior que zero.");
                }
                peso = value;
            }
        }

        public string LarTemporario
        {
            get { return larTemporario; }
            set { larTemporario = value; }
        }

        public string Castrado
        {
            get { return castrado; }
            set { castrado = value; }
        }
        public string VacinasEmDia
        {
            get { return vacinasEmDia; }
            set { vacinasEmDia = value; }
        }

        public List<string> Vacinas
        {
            get { return vacinas; }
            set { vacinas = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string TesteFIV
        {
            get { return testeFIV; }
            set { testeFIV = value; }
        }

        public string TesteFelv
        {
            get { return testeFelv; }
            set { testeFelv = value; }
        }

        public string Doencas
        {
            get { return doencas; }
            set { doencas = value; }
        }

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public DateTime DataChegadaOng
        {
            get { return dataChegadaOng; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("A data de chegada na ONG não pode ser futura.");
                }
                dataChegadaOng = value;
            }
        }

        public string CaminhoFoto
        {
            get { return caminhoFoto; }
            set { caminhoFoto = value; }
        }

        public string LocalResgate
        {
            get { return localResgate; }
            set { localResgate = value; }
        }

        public double? Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public double? Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("A data de cadastro não pode ser futura.");
                }
                dataCadastro = value;
            }
        }

        public DateTime Data_Adocao
        {
            get { return dataAdocao; }
            set { dataAdocao = value; }
        }

        public int? IdLarTemporario { get; set; }


    }
}
