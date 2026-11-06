using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    public class Gato
    {
        public string NumeroMicrochip { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Pelagem { get; set; }
        public string Coloracao { get; set; }
        public float Peso { get; set; }
        public string LarTemporario { get; set; }
        public string Castrado { get; set; }
        public string VacinasEmDia { get; set; }
        public List<string> Vacinas { get; set; } = new List<string>();
        public string Status { get; set; }
        public string TesteFIV { get; set; }
        public string TesteFelv { get; set; }
        public string Doencas { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataChegadaOng { get; set; }
        public string CaminhoFoto { get; set; }
        public string LocalResgate { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime Data_Adocao { get; set; }
        

    }
}
