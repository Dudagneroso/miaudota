using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace miaudota
{
    public partial class ucCadastroGato : UserControl
    {
        string caminhoFotoSelecionada = string.Empty;
        public ucCadastroGato()
        {
            InitializeComponent();
        }

        // Botão para escolher a foto do gato
        private void btnEscolherFoto_Click(object sender, EventArgs e)
        {
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                pbFotoGato.Image = Image.FromFile(ofdFoto.FileName);
                caminhoFotoSelecionada = ofdFoto.FileName;
            }
        }

        // Armazenar a latitude e longitude selecionadas
        double? latitudeSelecionada;
        double? longitudeSelecionada;

        private async void ucCadastroGato_Load(object sender, EventArgs e)
        {
            await wvMapa.EnsureCoreWebView2Async();
            // mapear a pasta Mapa para um endereço virtual
            wvMapa.CoreWebView2.SetVirtualHostNameToFolderMapping("miaudota.local", Path.Combine(Application.StartupPath, "Mapa"), CoreWebView2HostResourceAccessKind.Allow);
            // assinar o evento WebMessageReceived
            wvMapa.CoreWebView2.WebMessageReceived += RegistrarLocal;
            // navegar para a página
            wvMapa.CoreWebView2.Navigate("https://miaudota.local/mapa.html");
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
            pnlMapa.Visible = rbSimLocal.Checked;
        }
    }
}
