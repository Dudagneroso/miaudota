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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace miaudota.Telas
{
    public partial class ucEdicaoGato : UserControl
    {
        private byte[] imagemSelecionada;
        private Gato gatoAtual;

        public ucEdicaoGato()
        {
            InitializeComponent();
        }

        public void CarregarGato(Gato gato)
        {
            gatoAtual = gato;
            txtMicrochip.Text = gato.NumeroMicrochip;
            txtNome.Text = gato.Nome;
            dtpDataNascimento.Value = gato.DataNascimento;

            rbMacho.Checked = gato.Sexo == "Macho";
            rbFemea.Checked = gato.Sexo == "Fêmea";

            cbPelagem.Text = gato.Pelagem;
            cbColoracao.Text = gato.Coloracao;
            txtPeso.Text = gato.Peso.ToString();

            cbLarTemporario.DataSource = RepositorioLaresTemporarios.ObterComVaga(gato.IdLarTemporario);
            cbLarTemporario.DisplayMember = "TextoExibicao";
            cbLarTemporario.ValueMember = "Id";

            if (gato.IdLarTemporario.HasValue)
                cbLarTemporario.SelectedValue = gato.IdLarTemporario.Value;
            else
                cbLarTemporario.SelectedIndex = -1;

            rbCastrado.Checked = gato.Castrado == "Sim";
            rbNaoCastrado.Checked = gato.Castrado == "Não";

            rbVacinado.Checked = gato.VacinasEmDia == "Sim";
            rbNaoVacinado.Checked = gato.VacinasEmDia == "Não";

            for (int i = 0; i < clbVacinas.Items.Count; i++)
            {
                clbVacinas.SetItemChecked(i, gato.Vacinas.Contains(clbVacinas.Items[i].ToString()));
            }

            cbStatus.SelectedItem = gato.Status;
            cbFIV.Text = gato.TesteFIV;
            cbFELV.Text = gato.TesteFelv;
            txtDeficiencia.Text = gato.Doencas;
            txtObservacoes.Text = gato.Observacoes;
            dtpDataEntrada.Value = gato.DataChegadaOng;

            imagemSelecionada = gato.Foto;
            if (imagemSelecionada != null && imagemSelecionada.Length > 0)
            {
                using (var ms = new MemoryStream(imagemSelecionada))
                {
                    pbFotoGato.Image = Image.FromStream(ms);
                }
            }

            rbSimLocal.Checked = gato.LocalResgate == "Sim";
            rbNaoLocal.Checked = gato.LocalResgate == "Não";
            latitudeSelecionada = gato.Latitude;
            longitudeSelecionada = gato.Longitude;
            var _ = MarcarNoMapa();
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

            wvMapa.CoreWebView2.WebMessageReceived += RegistrarLocal;
            wvMapa.CoreWebView2.NavigationCompleted += MapaCarregado;
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

            if (rbSimLocal.Checked && mapaPronto)
                wvMapa.CoreWebView2.ExecuteScriptAsync("mapa.invalidateSize();");
        }

        private bool mapaPronto = false;

        private async void MapaCarregado(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            mapaPronto = true;
            await MarcarNoMapa();
        }

        private async Task MarcarNoMapa()
        {
            if (!mapaPronto) return;

            if (latitudeSelecionada.HasValue && longitudeSelecionada.HasValue)
            {
                string lat = latitudeSelecionada.Value.ToString(CultureInfo.InvariantCulture);
                string lng = longitudeSelecionada.Value.ToString(CultureInfo.InvariantCulture);
                await wvMapa.CoreWebView2.ExecuteScriptAsync("marcarLocal(" + lat + ", " + lng + ");");
            }
            else
            {
                await wvMapa.CoreWebView2.ExecuteScriptAsync("limparMarcador();");
            }
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (gatoAtual == null) return;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do gato.");
                return;
            }

            gatoAtual.NumeroMicrochip = txtMicrochip.Text;
            gatoAtual.Nome = txtNome.Text;
            gatoAtual.DataNascimento = dtpDataNascimento.Value;
            gatoAtual.Sexo = rbMacho.Checked ? "Macho" : rbFemea.Checked ? "Fêmea" : null;
            gatoAtual.Pelagem = cbPelagem.Text;
            gatoAtual.Coloracao = cbColoracao.Text;
            gatoAtual.Peso = float.TryParse(txtPeso.Text, out float peso) ? peso : 0;
            gatoAtual.IdLarTemporario = cbLarTemporario.SelectedValue == null
                ? (int?)null
                : Convert.ToInt32(cbLarTemporario.SelectedValue);
            gatoAtual.Castrado = rbCastrado.Checked ? "Sim" : rbNaoCastrado.Checked ? "Não" : null;
            gatoAtual.VacinasEmDia = rbVacinado.Checked ? "Sim" : "Não";
            gatoAtual.Vacinas = clbVacinas.CheckedItems.Cast<string>().ToList();
            gatoAtual.Status = cbStatus.SelectedItem?.ToString();
            if (gatoAtual.Status == "Adotado")
                gatoAtual.IdLarTemporario = null;
            gatoAtual.TesteFIV = cbFIV.Text;
            gatoAtual.TesteFelv = cbFELV.Text;
            gatoAtual.Doencas = txtDeficiencia.Text;
            gatoAtual.Observacoes = txtObservacoes.Text;
            gatoAtual.DataChegadaOng = dtpDataEntrada.Value;
            gatoAtual.Foto = imagemSelecionada;
            gatoAtual.LocalResgate = rbSimLocal.Checked ? "Sim" : "Não";
            gatoAtual.Latitude = rbSimLocal.Checked ? latitudeSelecionada : null;
            gatoAtual.Longitude = rbSimLocal.Checked ? longitudeSelecionada : null;

            try
            {
                RepositorioGatos.Atualizar(gatoAtual);
                MessageBox.Show("Dados do gato atualizados com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtMicrochip.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            rbMacho.Checked = false;
            rbFemea.Checked = false;
            cbPelagem.SelectedIndex = -1;
            cbColoracao.SelectedIndex = -1;
            txtPeso.Clear();
            cbLarTemporario.SelectedIndex = -1;
            rbCastrado.Checked = false;
            rbNaoCastrado.Checked = false;
            rbVacinado.Checked = false;
            rbNaoVacinado.Checked = false;
            for (int i = 0; i < clbVacinas.Items.Count; i++)
            {
                clbVacinas.SetItemChecked(i, false);
            }
            cbStatus.SelectedIndex = -1;
            cbFIV.SelectedIndex = -1;
            cbFELV.SelectedIndex = -1;
            txtDeficiencia.Clear();
            txtObservacoes.Clear();
            dtpDataEntrada.Value = DateTime.Now;
            imagemSelecionada = null;
            pbFotoGato.Image?.Dispose();
            pbFotoGato.Image = null;
            rbSimLocal.Checked = false;
            rbNaoLocal.Checked = false;
            latitudeSelecionada = null;
            longitudeSelecionada = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gatoAtual == null) return;

            var resposta = MessageBox.Show(
                "Tem certeza que deseja excluir o gato " + gatoAtual.Nome + "?\n\n" +
                "Todas as ocorrências e adoções vinculadas a ele também serão removidas. Esta ação não pode ser desfeita.",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes) return;

            try
            {
                RepositorioGatos.Excluir(gatoAtual);
                MessageBox.Show("Gato excluído com sucesso.");

                gatoAtual = null;
                // limpar a tela ou voltar para a listagem
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }
    }
}
