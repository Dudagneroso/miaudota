using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    internal class RepositorioOcorrencia
    {
        private static readonly List<OcorrenciaGato> ocorrencias = 
            new List<OcorrenciaGato>()
            { 
                new OcorrenciaGato
                {
                    NumeroMicrochip = "001",
                    Tipo = "Devolução",
                    Data = new DateTime(2026, 4, 3),
                    Local = "Mundo Felino",
                    Responsavel = "Ana",
                    Descricao = "Delvovido para o abrigo"
                },
                new OcorrenciaGato 
                { 
                    NumeroMicrochip = "001", 
                    Tipo = "Internação", 
                    Data = new DateTime(2026, 1, 1), 
                    Local = "Clinica Pet", 
                    Responsavel = "Ana", 
                    Descricao = "Internado por problemas de saúde" 
                }
        };

        public static void Adicionar(OcorrenciaGato ocorrencia)
        {
            // acrescentar na lista
            ocorrencias.Add(ocorrencia);
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
