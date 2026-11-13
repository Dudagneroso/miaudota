using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    public class Tutor
    {

        private string nome;
        private string cpf;
        private string telefone;
        private DateTime dataNascimento;
        private string email;
        private string cep;
        private string cidade;
        private string estado;
        private string logradouro;
        private string bairro;
        private int numero;
        private string tipoResidencia;
        private string outrosAnimais;
        private List<Gato> gatos = new List<Gato>();
        private DateTime dataAdocao;

        public Tutor()
        {

        }

        public Tutor(string nome, string cpf, string telefone, DateTime dataNascimento, string email, string cep, string cidade, string estado, string logradouro, string bairro, int numero, string tipoResidencia, string outrosAnimais, List<Gato> gatos, DateTime dataAdocao)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.dataNascimento = dataNascimento;
            this.email = email;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.numero = numero;
            this.tipoResidencia = tipoResidencia;
            this.outrosAnimais = outrosAnimais;
            this.gatos = gatos;
            this.dataAdocao = dataAdocao;
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                nome = value;
            }
        }
        public string CPF
        {
            get { return cpf; }
            set { 
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O CPF não pode ser vazio.");
                }
                if (value.Length != 11)
                {
                    throw new ArgumentException("O CPF deve ter exatamente 11 caracteres.");
                }
                cpf = value; 
            }
        }
        public string Telefone
        {
            get { return telefone; }
            set { 
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O telefone não pode ser vazio.");
                }
                if (value.Length < 10 || value.Length > 11)
                {
                    throw new ArgumentException("O telefone deve ter entre 10 e 11 caracteres.");
                }
                telefone = value; 
            }
        }
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public string Email
        {
            get { return email; }
            set 
            {
                if(value == null || !value.Contains("@"))
                {
                    throw new ArgumentException("O email deve conter um '@'.");
                }
                email = value; 
            }
        }
        public string CEP
        {
            get { return cep; }
            set 
            {
                string digitos = new string((value ?? "").Where(char.IsDigit).ToArray());
                if (string.IsNullOrWhiteSpace(digitos))
                {
                    throw new ArgumentException("O CEP não pode ser vazio.");
                }
                if(digitos.Length != 8)
                {
                    throw new ArgumentException("O CEP deve ter exatamente 8 caracteres.");
                }
                cep = digitos; 
            }
        }
        public string Cidade
        {
            get { return cidade; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Preencha a cidade.");
                }
                cidade = value; 
            }
        }
        public string Estado
        {
            get { return estado; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Preencha o estado.");
                }
                estado = value; 
            }
        }
        public string Logradouro
        {
            get { return logradouro; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Preencha o logradouro.");
                }
                logradouro = value;
            }
        }
        public string Bairro
        {
            get { return bairro; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Preencha o bairro.");
                }
                bairro = value; 
            }
        }
        public int Numero
        {
            get { return numero; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value.ToString()))
                {
                    throw new ArgumentException("Preencha o número da residência.");
                }

                if (value < 0)
                {
                    throw new ArgumentException("O número da residência não pode ser negativo.");
                }
                numero = value; 
            }
        }
        public string TipoResidencia
        {
            get { return tipoResidencia; }
            set { tipoResidencia = value; }
        }
        public string OutrosAnimais
        {
            get { return outrosAnimais; }
            set { outrosAnimais = value; }
        }
        public List<Gato> Gatos
        {
            get { return gatos; }
            set { gatos = value; }
        }
        public DateTime DataAdocao
        {
            get { return dataAdocao; }
            set { dataAdocao = value; }
        }

        public int Id { get; set; }
        public void AdotarGato(Gato gato)
        {
            if (gato == null)
            {
                throw new InvalidOperationException("Selecione um gato para adotar.");
            }
            if (gato.Status != "Disponível")
            {
                throw new InvalidOperationException("Este gato não está disponível para adoção.");
            }
            gatos.Add(gato);
            gato.Status = "Adotado";
            gato.Data_Adocao = DateTime.Today;
        }

    }
}
