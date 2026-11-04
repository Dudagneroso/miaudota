using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    internal class RepositorioOcorrencia
    {
        private static readonly List<OcorrenciaGato> ocorrencias = new List<OcorrenciaGato> { /* ocorrências de teste */ };

        public static void Adicionar(OcorrenciaGato ocorrencia)
        {
            // acrescentar na lista
        }

        public static List<OcorrenciaGato> ObterPorGato(string microchip)
        {
            // Where pelo microchip, OrderByDescending pela Data, ToList
            return ocorrencias
                      .Where(o => o.NumeroMicrochip == microchip)
                      .OrderByDescending(o => o.Data)
                      .ToList();
        }
    }
}
