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
        string nomeGato = string.Empty;

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

            cbStatus.SelectedIndex = 0;
        }

        private void RegistrarLocal(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            // pegar o texto com e.TryGetWebMessageAsString()
            string informacoes = e.TryGetWebMessageAsString();

            // separar com .Split(';')
            string[] partes = informacoes.Split(';');

            // verificar se tem duas partes e se são números
            if (partes.Length == 2 && double.TryParse(partes[0], NumberStyles.Float,
            CultureInfo.InvariantCulture, out double latitude) &&
            double.TryParse(partes[1], NumberStyles.Float,
            CultureInfo.InvariantCulture, out double longitude))
            {
                // guardar nas variáveis latitudeSelecionada e longitudeSelecionada
                latitudeSelecionada = double.Parse(partes[0], CultureInfo.InvariantCulture);
                longitudeSelecionada = double.Parse(partes[1], CultureInfo.InvariantCulture);
            }
        }

        private void rbSimLocal_CheckedChanged(object sender, EventArgs e)
        {
            pnlMapa.Visible = rbSimLocal.Checked;
        }

        private void rbVacinado_CheckedChanged(object sender, EventArgs e)
        {
            pnlVacinasTomadas.Visible = rbVacinado.Checked || rbNaoVacinado.Checked;
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtMicrochip.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            rbMacho.Checked = false;
            rbFemea.Checked = false;
            cbPelagem.SelectedIndex = -1;
            cbColoracao.SelectedIndex = -1;
            txtPeso.Clear();
            txtLarTemporario.Clear();
            rbCastrado.Checked = false;
            rbNaoCastrado.Checked = false;
            rbVacinado.Checked = false;
            rbNaoVacinado.Checked = false;
            cbStatus.SelectedIndex = -1;
            cbFIV.SelectedIndex = -1;
            cbFELV.SelectedIndex = -1;
            txtDeficiencias.Clear();
            txtObservacao.Clear();
            dtpDataEntrada.Value = DateTime.Now;
            caminhoFotoSelecionada = string.Empty;
            rbSimLocal.Checked = false;
            rbNaoLocal.Checked = false;
            latitudeSelecionada = null;
            longitudeSelecionada = null;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // validar se o local de resgate foi selecionado
                if (rbSimLocal.Checked && (!latitudeSelecionada.HasValue || !longitudeSelecionada.HasValue))
                {
                    MessageBox.Show("Por favor, selecione o local de resgate no mapa.");
                    return;
                }

                // 1. montar o objeto Gato com os dados da tela
                Gato gato = new Gato
                {
                    NumeroMicrochip = txtMicrochip.Text,
                    Nome = txtNome.Text,
                    DataNascimento = dtpDataNascimento.Value,
                    Sexo = rbMacho.Checked ? "Macho" : "Fêmea",
                    Pelagem = cbPelagem.Text,
                    Coloracao = cbColoracao.Text,
                    Peso = float.TryParse(txtPeso.Text, out float peso) ? peso : 0,
                    LarTemporario = txtLarTemporario.Text,
                    Castrado = rbCastrado.Checked ? "Sim" : "Não",
                    VacinasEmDia = rbVacinado.Checked ? "Sim" : "Não",
                    Vacinas = clbVacinas.CheckedItems.Cast<string>().ToList(),
                    Status = cbStatus.SelectedItem?.ToString(),
                    TesteFIV = cbFIV.Text,
                    TesteFelv = cbFELV.Text,
                    Doencas = txtDeficiencias.Text,
                    Observacoes = txtObservacao.Text,
                    DataChegadaOng = dtpDataEntrada.Value,
                    CaminhoFoto = caminhoFotoSelecionada,
                    LocalResgate = rbSimLocal.Checked ? "Sim" : "Não",
                    Latitude = latitudeSelecionada,
                    Longitude = longitudeSelecionada,
                    DataCadastro = DateTime.Now
                };

                // 2. guardar no repositório e gatos
                RepositorioGatosFake.Adicionar(gato);

                // 3. Mensagem de Sucesso
                MessageBox.Show("Gato cadastrado com sucesso!");

                // 4. limpar o formulário
                LimparFormulario();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }
    }
}
