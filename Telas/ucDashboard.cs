using Microsoft.Web.WebView2.Core;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miaudota.Telas
{
    public partial class ucDashboard : UserControl
    {

        public ucDashboard()
        {
            InitializeComponent();
            AtualizarIndicadoresGatos(RepositorioGatosFake.ObterTodos());
            AtualizarGraficos();
        }



        private void AtualizarIndicadoresGatos(List<Gato> gatos)
        {
            lblNumGatos.Text = gatos.Count.ToString();

            if (gatos.Count > 0)
            {
                int numGatosAdotados = gatos.Count(g => g.Status == "Adotado");
                lblQtdAdocoes.Text = numGatosAdotados.ToString();

                double mediaDias = gatos
                    .Where(g => g.Status == "Adotado" && g.Data_Adocao != null && g.DataChegadaOng != null)
                    .Average(g => (g.Data_Adocao - g.DataChegadaOng).TotalDays);
                lblTempoOng.Text = $"{mediaDias.ToString("F0")} dias";

            }
            else
            {
                lblQtdAdocoes.Text = "0";
            }

        }

        private void AtualizarGraficos()
        {
            List<Gato> gatos = RepositorioGatosFake.ObterTodos();

            //Contar gatos por status
            int disponiveis = gatos.Count(g => g.Status == "Disponível");
            int adotados = gatos.Count(g => g.Status == "Adotado");
            int emProcesso = gatos.Count(g => g.Status == "Em processo");
            int larTemporario = gatos.Count(g => g.Status == "Lar temporário");

            // Adoções por idade
            int filhotes = 0;
            int adultos = 0;
            int idosos = 0;

            //Contar gatos por pelagem
            int preta = 0;
            int branca = 0;
            int laranja = 0;
            int cinza = 0;
            int marrom = 0;
            int tigrada = 0;
            int tricolor = 0;
            int frajola = 0;
            int bicolor = 0;
            int siamese = 0;

            foreach (Gato gato in gatos.Where(g => g.Status == "Adotado"))
            {
                //calcular idade do gato no momento da adoção
                int idade = gato.Data_Adocao.Year - gato.DataNascimento.Year;

                // Ajustar se o aniversário ainda não ocorreu no ano da adoção
                if (gato.DataNascimento.Date > gato.Data_Adocao.AddYears(-idade).Date)
                {
                    idade--;
                }

                if (idade <= 1)
                {
                    filhotes++;

                }
                else if (idade <= 7)
                {
                    adultos++;
                }
                else
                {
                    idosos++;

                }

                //Contar gatos por pelagem
                if (gato.Status == "Adotado")
                {
                    switch (gato.Coloracao)
                    {
                        case "Preta":
                            preta++;
                            break;
                        case "Branca":
                            branca++;
                            break;
                        case "Vermelha/Laranja":
                            laranja++;
                            break;
                        case "Cinza":
                            cinza++;
                            break;
                        case "Marrom":
                            marrom++;
                            break;
                        case "Tigrada":
                            tigrada++;
                            break;
                        case "Tricolor":
                            tricolor++;
                            break;
                        case "Frajola":
                            frajola++;
                            break;
                        case "Bicolor":
                            bicolor++;
                            break;
                        case "Siamês":
                            siamese++;
                            break;
                    }
                }

                //atualizar grafico de status
                chartStatus.Series[0].Points[0].YValues[0] = disponiveis;
                chartStatus.Series[0].Points[1].YValues[0] = emProcesso;
                chartStatus.Series[0].Points[2].YValues[0] = adotados;
                chartStatus.Series[0].Points[3].YValues[0] = larTemporario;

                //atualizar grafico de idade
                chartIdade.Series[0].Points[0].YValues[0] = adultos;
                chartIdade.Series[0].Points[1].YValues[0] = filhotes;
                chartIdade.Series[0].Points[2].YValues[0] = idosos;

                //atualizar grafico de pelagem
                chartPelagem.Series[0].Points[0].YValues[0] = preta;
                chartPelagem.Series[0].Points[1].YValues[0] = branca;
                chartPelagem.Series[0].Points[2].YValues[0] = laranja;
                chartPelagem.Series[0].Points[3].YValues[0] = cinza;
                chartPelagem.Series[0].Points[4].YValues[0] = marrom;
                chartPelagem.Series[0].Points[5].YValues[0] = tigrada;
                chartPelagem.Series[0].Points[6].YValues[0] = tricolor;
                chartPelagem.Series[0].Points[7].YValues[0] = frajola;
                chartPelagem.Series[0].Points[8].YValues[0] = bicolor;
                chartPelagem.Series[0].Points[9].YValues[0] = siamese;

            }


        }

        private async Task AtualizarMapaCalor()
        {
            // Buscar gatos cadastrados
            List<Gato> gatos = RepositorioGatosFake.ObterTodos();

            // Selecionar somente gatos com local de resgate
            var gatosComLocal = gatos
        .Where(g => g.LocalResgate == "Sim"
                 && g.Latitude.HasValue
                 && g.Longitude.HasValue)
        .ToList();


            var pontos = gatosComLocal
                .Select(g => string.Format(
                    CultureInfo.InvariantCulture,
                    "[{0:R},{1:R},1]",
                    g.Latitude.Value,
                    g.Longitude.Value
                ))
                .ToList();


            // Transformar os pontos em JSON
            string json = "[" + string.Join(",", pontos) + "]";

            // Enviar os dados para o JavaScript
            await wvMapaCalor.CoreWebView2.ExecuteScriptAsync(
                "atualizarMapa(" + json + ");"
            );
        }

        private async void ucDashboard_Load(object sender, EventArgs e)
        {
            await wvMapaCalor.EnsureCoreWebView2Async();
            // Mapear a pasta dos arquivos HTML
            wvMapaCalor.CoreWebView2.SetVirtualHostNameToFolderMapping(
                "miaudota.local",
                Path.Combine(Application.StartupPath, "Mapa"),
                CoreWebView2HostResourceAccessKind.Allow
            );

            // Esperar o mapa carregar para enviar os dados
            wvMapaCalor.NavigationCompleted += async (s, args) =>
            {
                if (args.IsSuccess)
                {
                    await AtualizarMapaCalor();
                }
            };

            wvMapaCalor.CoreWebView2.Navigate(
                "https://miaudota.local/mapa-calor.html"
            );
        
        }
    }
}
