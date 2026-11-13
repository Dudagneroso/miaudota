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
            AtualizarIndicadoresGatos();
        }

        private DateTime? ObterPeriodo()
        {
            DateTime hoje = DateTime.Today;

            if (rbMes.Checked)
            {
                return new DateTime(hoje.Year, hoje.Month, 1);
            }
            else if (rb6Meses.Checked)
            {
                return hoje.Month <= 6
                    ? new DateTime(hoje.Year, 1, 1)
                    : new DateTime(hoje.Year, 7, 1);
            }
            else if (rbAno.Checked)
            {
                return new DateTime(hoje.Year, 1, 1);
            }

            return null;
        }

        private DateTime? ObterFimPeriodo()
        {
            DateTime? inicio = ObterPeriodo();

            if (inicio == null)
                return null;

            if (rbMes.Checked)
                return inicio.Value.AddMonths(1);

            if (rb6Meses.Checked)
                return inicio.Value.AddMonths(6);

            if (rbAno.Checked)
                return inicio.Value.AddYears(1);

            return null;
        }

        private void AtualizarIndicadoresGatos()
        {
            List<Gato> todosGatos = RepositorioGatos.ObterTodos();

            DateTime? inicio = ObterPeriodo();
            DateTime? fim = ObterFimPeriodo();

            // Gatos recebidos no período
            List<Gato> gatosEntrada = todosGatos
                .Where(g => inicio == null ||
                    (g.DataChegadaOng >= inicio.Value &&
                     g.DataChegadaOng < fim.Value))
                .ToList();

            // Gatos adotados no período
            List<Gato> gatosAdotados = todosGatos
                .Where(g => g.Status == "Adotado" &&
                    (inicio == null ||
                     (g.Data_Adocao >= inicio.Value &&
                      g.Data_Adocao < fim.Value)))
                .ToList();

            // Atualizar indicadores
            lblNumGatos.Text = gatosEntrada.Count.ToString();
            lblQtdAdocoes.Text = gatosAdotados.Count.ToString();

            var gatosComDatas = gatosAdotados
                .Where(g => g.Data_Adocao != null &&
                            g.DataChegadaOng != null)
                .ToList();

            if (gatosComDatas.Count > 0)
            {
                double mediaDias = gatosComDatas
                    .Average(g => (g.Data_Adocao - g.DataChegadaOng).TotalDays);

                lblTempoOng.Text = $"{mediaDias:F0} dias";
            }
            else
            {
                lblTempoOng.Text = "0 dias";
            }

            // Atualizar indicadores de período
            string periodo = rbMes.Checked ? "neste mês" :
                             rb6Meses.Checked ? "neste semestre" :
                             rbAno.Checked ? "neste ano" : "no total";

            lblQtdGatoPeriodo.Text =
                $"+{gatosEntrada.Count} {periodo}";

            lblQtdAdocaoPeriodo.Text =
                $"+{gatosAdotados.Count} {periodo}";

            // Atualizar todos os gráficos
            AtualizarGraficos(todosGatos, gatosAdotados);
            AtualizarGraficoEntradasAdocoes();

        }

        private void AtualizarGraficoEntradasAdocoes()
        {
            List<Gato> todosGatos = RepositorioGatos.ObterTodos();

            DateTime hoje = DateTime.Today;

            
            DateTime inicio;
            DateTime fim;

            if (rbMes.Checked)
            {
                inicio = new DateTime(hoje.Year, hoje.Month, 1);
                fim = inicio.AddMonths(1);
            }
            else if (rb6Meses.Checked)
            {
                inicio = ObterPeriodo().Value;
                fim = inicio.AddMonths(6);
            }
            else
            {
                //Ano atual, inclusive quando nenhum filtro estiver selecionado
                inicio = new DateTime(hoje.Year, 1, 1);
                fim = inicio.AddYears(1);
            }

            //Limpar os pontos anteriores
            chartEntradasAdocoes.Series[0].Points.Clear();
            chartEntradasAdocoes.Series[1].Points.Clear();

            //Percorrer os meses do período
            for (DateTime mes = new DateTime(inicio.Year, inicio.Month, 1); mes < fim; mes = mes.AddMonths(1))
            {
                DateTime inicioMes = mes;
                DateTime fimMes = mes.AddMonths(1);

                //Contar entradas no mês
                int entradas = todosGatos.Count(g => g.DataChegadaOng >= inicioMes && g.DataChegadaOng < fimMes);

                //Contar addoções no mês
                int adocoes = todosGatos.Count(g => g.Status == "Adotado" && g.Data_Adocao > DateTime.MinValue && g.Data_Adocao >= inicioMes && g.Data_Adocao < fimMes);

                string nomeMes = mes.ToString("MMM", new CultureInfo("pt-BR"));

                //Adicionar valores aos gráficos
                chartEntradasAdocoes.Series[0].Points.AddXY(nomeMes, entradas);

                chartEntradasAdocoes.Series[1].Points.AddXY(nomeMes, adocoes);
            }

            //Alterar subtitulo
            if (rbMes.Checked)
            {
                chartEntradasAdocoes.Titles["Movimentacao"].Text =
                    "Movimentação neste mês";
            }
            else if (rb6Meses.Checked)
            {
                chartEntradasAdocoes.Titles["Movimentacao"].Text =
                    "Movimentação nos últimos 6 meses";
            }
            else
            {
                chartEntradasAdocoes.Titles["Movimentacao"].Text =
                    "Movimentação neste ano";
            }

            // Mostrar todos os meses no eixo horizontal
            chartEntradasAdocoes.ChartAreas[0].AxisX.Interval = 1;

            // Evitar que o gráfico oculte automaticamente os rótulos
            chartEntradasAdocoes.ChartAreas[0].AxisX.IsLabelAutoFit = false;

            // Manter os nomes dos meses na horizontal
            chartEntradasAdocoes.ChartAreas[0].AxisX.LabelStyle.Angle = 0;

            chartEntradasAdocoes.Refresh();
        }

        private void AtualizarGraficos(List<Gato> gatos, List<Gato> gatosAdotados)
        {

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

            foreach (Gato gato in gatosAdotados)
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

            chartIdade.Refresh();
            chartPelagem.Refresh();

        }

        private async Task AtualizarMapaCalor()
        {
            // Buscar gatos cadastrados
            List<Gato> gatos = RepositorioGatos.ObterTodos();

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

        private void rbMes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMes.Checked)
                AtualizarIndicadoresGatos();
        }

        private void rb6Meses_CheckedChanged(object sender, EventArgs e)
        {
            if (rb6Meses.Checked)
                AtualizarIndicadoresGatos();
        }

        private void rbAno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAno.Checked)
                AtualizarIndicadoresGatos();
        }
    }
}
