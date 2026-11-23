using miaudota.Telas;
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

namespace miaudota
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            FormClosing += FormPrincipal_FormClosing;
        }

        public void AbrirTela(UserControl tela)
        {
            pnlPerfilContainer.Visible = false;
            tela.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(tela);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AbrirTela(new ucConsulta());

        }

        private void btnCadastroGato_Click(object sender, EventArgs e)
        {
            RepositorioLaresTemporarios.SincronizarComAviso();
            AbrirTela(new ucCadastroGato());
        }

        private void btnCadastroTutor_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucCadastroTutor());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            RepositorioGatos.SincronizarTudo();
            AbrirTela(new ucConsultaGatos1());
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucConsulta());
        }

        private void btnConsultaTutor_Click(object sender, EventArgs e)
        {
            RepositorioTutores.SincronizarTudo();
            AbrirTela(new ucConsultaTutor());
        }

        public void MostrarPerfilGato(Gato gato)
        {
            Idade idade = Idade.Calcular(gato, DateTime.Today);

            lblNomeGato.Text = gato.Nome;
            lblIdadeGato.Text = idade.ToString();
            lblMicrochipGato.Text = gato.NumeroMicrochip;
            lblStatusGato.Text = gato.Status;
            Image fotoAnterior = pbFotoGato.Image;

            if (gato.Foto != null && gato.Foto.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(gato.Foto))
                using (Image img = Image.FromStream(ms))
                {
                    pbFotoGato.Image = new Bitmap(img);
                }
            }
            else
            {
                pbFotoGato.Image = Properties.Resources.sem_foto;
            }

            // libera a foto anterior, menos a imagem padrão dos recursos
            if (fotoAnterior != null && fotoAnterior != Properties.Resources.sem_foto)
            {
                fotoAnterior.Dispose();
            }

            // Muda a cor do status para vermelho se o gato não estiver disponível, caso contrário, mantém a cor padrão
            if (gato != null && gato.Status != "Disponível")
            {
                lblStatusGato.BackColor = Color.FromArgb(255, 192, 192); // Cor de fundo vermelha
            }
            else
            {
                lblStatusGato.BackColor = Color.FromArgb(192, 255, 192); // Cor de fundo verde
            }

            pnlPerfilContainer.Visible = true;
        }

        private void btnOcorrencia_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucOcorrencia());
        }

        private void btnDashboards_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucDashboard());
        }

        private void btnCadastroLar_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucCadastroLar());
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            RepositorioGatos.SincronizarTudo();
            List<string> erros = new List<string>();

            try
            {
                RepositorioGatos.Sincronizar();
            }
            catch (Exception ex)
            {
                erros.Add(ex.Message);
            }

            try
            {
                RepositorioOcorrencia.Sincronizar();
            }
            catch (Exception ex)
            {
                erros.Add(ex.Message);
            }

            if (erros.Count > 0)
            {
                DialogResult resposta = MessageBox.Show(
                    string.Join("\n\n", erros) + "\n\nSair mesmo assim?",
                    "Cadastros pendentes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resposta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void llblSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente sair e voltar para a tela de login?", "Confirmar Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Close();
            }

        }
    }
}
