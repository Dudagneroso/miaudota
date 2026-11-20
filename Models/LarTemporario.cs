using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    internal class LarTemporario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string TipoMoradia { get; set; }
        public string Capacidade { get; set; }
        public string OutrosAnimais { get; set; }
        public string Disponibilidade { get; set; }
        public DateTime InicioDisponivel { get; set; }
        public string Observacoes { get; set; }
    }
}
