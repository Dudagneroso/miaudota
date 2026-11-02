using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    internal class ViaCepResposta
    {
        public string Cidade { get; set; } //localidade
        public string Estado { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public bool Erro { get; set; } //Caso o CEP não seja encontrado, a API retorna um JSON com a propriedade "erro" definida como true.
    }
}
