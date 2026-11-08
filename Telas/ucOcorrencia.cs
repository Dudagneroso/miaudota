using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miaudota.Telas
{
    public partial class ucOcorrencia : UserControl
    {
        private Ocorrencia tipoSelecionado;
        public ucOcorrencia()
        {
            InitializeComponent();

            List<Ocorrencia> tipos = TiposOcorrencia.ObterTodos();
            int indice = 0;

            foreach (Ocorrencia tipo in tipos)
            {
                ucCartaoOcorrencia cartao = new ucCartaoOcorrencia();
                cartao.CarregarDados(tipo);
                cartao.Dock = DockStyle.Fill;
                cartao.Margin = new Padding(6);
                cartao.CartaoClicado += SelecionarCartao;
                //cartao.Selecionado += SelecionarCartao;

                //coluna = indice % 3, linha = indice / 3
                tlpTipos.Controls.Add(cartao, indice % 3, indice / 3);

                indice++;
            }
        }

        private void SelecionarCartao(object sender, EventArgs e)
        {
            ucCartaoOcorrencia clicado = (ucCartaoOcorrencia)sender;

            foreach (ucCartaoOcorrencia c in tlpTipos.Controls.OfType<ucCartaoOcorrencia>())
            {
                c.Selecionado = false;
            }

            clicado.Selecionado = true;
            tipoSelecionado = clicado.Ocorrencia;
            // guardar o tipo escolhido em uma variável de classe
            OcorrenciaGato ocorrencia = new OcorrenciaGato
            {
                Tipo = clicado.Ocorrencia.Nome
            };

        }



        public void mostrarGato(Gato gato)
        {
            Idade idade = Idade.Calcular(gato, DateTime.Today);

            lblNome.Text = gato.Nome;
            lblIdadeMicrochip.Text = $"{idade} . {gato.NumeroMicrochip}";
            lblStatus.Text = gato.Status;
            if (string.IsNullOrEmpty(gato.CaminhoFoto))
            {
                pbFoto.Image = Properties.Resources.sem_foto;
            }
            else
            {
                pbFoto.Image = Image.FromFile(gato.CaminhoFoto);
            }
        }

        private void LimparFormulario()
        {
            txtMicrochip.Clear();
            dtpDataOcorrencia.Value = DateTime.Now;
            txtLocal.Clear();
            txtResponsavel.Clear();
            txtMotivo.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void txtMicrochip_TextChanged(object sender, EventArgs e)
        {
            Gato gato = RepositorioGatosFake.ObterTodos().FirstOrDefault(g => g.NumeroMicrochip == txtMicrochip.Text.Trim());

            // Verifica se o campo do microchip não está vazio ou apenas com espaços
            bool temMicrochip = !string.IsNullOrWhiteSpace(txtMicrochip.Text);

            // Torna os campos visíveis
            lblNome.Visible = temMicrochip;
            lblIdadeMicrochip.Visible = temMicrochip;
            lblStatus.Visible = temMicrochip;
            pbFoto.Visible = temMicrochip;

            if (gato != null)
            {
                mostrarGato(gato);

            }

            // Muda a cor do status para vermelho se o gato não estiver disponível, caso contrário, mantém a cor padrão
            if (gato != null && gato.Status != "Disponível")
            {
                lblStatus.BackColor = Color.FromArgb(255, 192, 192); // Cor de fundo vermelha
            }
            else
            {
                lblStatus.BackColor = Color.FromArgb(192, 255, 192); // Cor de fundo verde
            }

        }

        private void btnSalvarOcorrencia_Click(object sender, EventArgs e)
        {
            Gato gato = RepositorioGatosFake.ObterTodos().FirstOrDefault(g => g.NumeroMicrochip == txtMicrochip.Text.Trim());

            try
            {


                OcorrenciaGato ocorrencia = new OcorrenciaGato
                {
                    NumeroMicrochip = txtMicrochip.Text,
                    Tipo = tipoSelecionado.Nome,
                    Data = dtpDataOcorrencia.Value,
                    Local = txtLocal.Text,
                    Responsavel = txtResponsavel.Text,
                    Descricao = txtMotivo.Text
                };

                if (tipoSelecionado.Nome == "Devolução")
                {
                    gato.Status = "Disponível";
                }

                RepositorioOcorrencia.Adicionar(ocorrencia);

                MessageBox.Show("Ocorrência registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparFormulario();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
    }
}
