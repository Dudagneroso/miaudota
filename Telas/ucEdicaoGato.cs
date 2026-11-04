using Microsoft.Web.WebView2.Core;
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
    public partial class ucEdicaoGato : UserControl
    {
        public ucEdicaoGato()
        {
            InitializeComponent();
        }

        public void CarregarGato(Gato gato)
        {
            txtMicrochip.Text = gato.NumeroMicrochip;
            txtNome.Text = gato.Nome;
            CarregarOcorrencias(gato);
        }

        // Armazenar a latitude e longitude selecionadas
        double? latitudeSelecionada;
        double? longitudeSelecionada;

        private async void ucEdicaoGato_Load(object sender, EventArgs e)
        {
            await wvMapa.EnsureCoreWebView2Async();
            // mapear a pasta Mapa para um endereço virtual
            wvMapa.CoreWebView2.SetVirtualHostNameToFolderMapping("miaudota.local", Path.Combine(Application.StartupPath, "Mapa"), CoreWebView2HostResourceAccessKind.Allow);
            // assinar o evento WebMessageReceived
            wvMapa.CoreWebView2.WebMessageReceived += RegistrarLocal;
            // navegar para a página
            wvMapa.CoreWebView2.Navigate("https://miaudota.local/mapa.html");

            rbDados.Checked = true;

        }

        private void RegistrarLocal(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            // pegar o texto com e.TryGetWebMessageAsString()
            string informacoes = e.TryGetWebMessageAsString();

            // separar com .Split(';')
            string[] partes = informacoes.Split(';');

            // guardar nas variáveis latitudeSelecionada e longitudeSelecionada
            latitudeSelecionada = double.Parse(partes[0], CultureInfo.InvariantCulture);
            longitudeSelecionada = double.Parse(partes[1], CultureInfo.InvariantCulture);
        }

        private void rbSimLocal_CheckedChanged(object sender, EventArgs e)
        {
            pnlLocal.Visible = rbSimLocal.Checked;
        }

        private void rbVacinado_CheckedChanged(object sender, EventArgs e)
        {
            lblCheckVacinas.Visible = rbVacinado.Checked || rbNaoVacinado.Checked;
            clbVacinas.Visible = rbVacinado.Checked || rbNaoVacinado.Checked;
        }

        private void rbOcorrencias_CheckedChanged(object sender, EventArgs e)
        {
            pnlOcorrencias.Visible = rbOcorrencias.Checked;
        }

        private void rbDados_CheckedChanged(object sender, EventArgs e)
        {
            pnlDados.Visible = rbDados.Checked;
        }

        private void AtualizarIndicadores(List<OcorrenciaGato> lista)
        {
            lblQtd.Text = lista.Count.ToString();

            //Verificar se existem ocorrências
            if (lista.Count > 0)
            {
                OcorrenciaGato ultima = lista[0];

                lblTipoUltimaOcorrencia.Text = ultima.Tipo;

                lblData.Text = ultima.Data.ToString("dd/MM/yyyy");
            }
            else
            {
                lblTipoUltimaOcorrencia.Text = "N/A";
                lblData.Text = "--/--/----";
            }
        }

        private void CarregarOcorrencias(Gato gato)
        {
            List<OcorrenciaGato> lista = RepositorioOcorrencia.ObterPorGato(gato.NumeroMicrochip);

            flpOcorrencias.Controls.Clear();
            AtualizarIndicadores(lista);

            foreach (OcorrenciaGato o in lista)
            {
                ucItemOcorrencia item = new ucItemOcorrencia();
                item.CarregarDados(o);
                item.Width = flpOcorrencias.ClientSize.Width
                     - flpOcorrencias.Padding.Horizontal
                     - item.Margin.Horizontal - 5;
                item.Height = 135;
                item.Margin = new Padding(0, 0, 0, 10);
                flpOcorrencias.Controls.Add(item);
            }
        }
    }
}
