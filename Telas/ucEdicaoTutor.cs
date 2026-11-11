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
    public partial class ucEdicaoTutor : UserControl
    {
        private Tutor tutorAtual;
        public ucEdicaoTutor()
        {
            InitializeComponent();
        }

        public void CarregarTutor(Tutor tutor)
        {
            lblNomeTutor.Text = tutor.Nome;
            lblEmailTutor.Text = tutor.Email;
            txtNome.Text = tutor.Nome;
            txtCPF.Text = tutor.CPF;
            dtpDataNascimento.Value = tutor.DataNascimento;
            txtEmail.Text = tutor.Email;
            txtTelefone.Text = tutor.Telefone;
            txtCep.Text = tutor.CEP;
            txtCidade.Text = tutor.Cidade;
            txtEstado.Text = tutor.Estado;
            txtLogradouro.Text = tutor.Logradouro;
            txtBairro.Text = tutor.Bairro;
            txtNumero.Text = tutor.Numero.ToString();
            cbTipoMoradia.Text = tutor.TipoResidencia;
            cbPets.Text = tutor.OutrosAnimais;
            tutorAtual = tutor;

            AtualizarGatosAdotados();
        }

        private void AtualizarGatosAdotados()
        {
            flpGatos.Controls.Clear();
            foreach (var gato in tutorAtual.Gatos)
            {
                ucCartaoGato cartao = new ucCartaoGato();

                cartao.CarregarDados(gato);
                flpGatos.Controls.Add(cartao);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNovoGato.Visible = !pnlNovoGato.Visible;
        }

        Gato gatoParaVincular = null;

        private void txtMicrochip_TextChanged(object sender, EventArgs e)
        {
            gatoParaVincular = null;

            if (string.IsNullOrWhiteSpace(txtMicrochip.Text))
            {
                lblNomeGato.Text = "";
                return;
            }

            Gato gato = RepositorioGatosFake.ObterTodos().FirstOrDefault(g => g.NumeroMicrochip == txtMicrochip.Text.Trim());

            if (gato == null)
            {
                lblNomeGato.Text = "Gato não encontrado";
                return;
            }

            if (gato.Status != "Disponível")
            {
                lblNomeGato.Text = "Este gato não está disponível";
                return;
            }

            lblNomeGato.Text = "Nome: " + gato.Nome;
            gatoParaVincular = gato;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja excluir este tutor?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                RepositorioTutores.Excluir(tutorAtual);

                MessageBox.Show("Tutor excluído com sucesso!");

                ((FormPrincipal)this.ParentForm).AbrirTela(new ucConsultaTutor());
            }
        }

        private void btnSalvarTutor_Click(object sender, EventArgs e)
        {
            // 1. montar o objeto Tutor com os dados da tela
            tutorAtual.Nome = txtNome.Text;
            tutorAtual.CPF = txtCPF.Text;
            tutorAtual.Telefone = txtTelefone.Text;
            tutorAtual.DataNascimento = dtpDataNascimento.Value;
            tutorAtual.Email = txtEmail.Text;
            tutorAtual.CEP = txtCep.Text;
            tutorAtual.Cidade = txtCidade.Text;
            tutorAtual.Estado = txtEstado.Text;
            tutorAtual.Logradouro = txtLogradouro.Text;
            tutorAtual.Bairro = txtBairro.Text;
            tutorAtual.Numero = int.Parse(txtNumero.Text);
            tutorAtual.TipoResidencia = cbTipoMoradia.SelectedItem?.ToString();
            tutorAtual.OutrosAnimais = cbPets.SelectedItem?.ToString();

            if (gatoParaVincular != null)
            {
                tutorAtual.Gatos.Add(gatoParaVincular);
                gatoParaVincular.Status = "Adotado";
                tutorAtual.DataAdocao = DateTime.Today;

                AtualizarGatosAdotados();

                pnlNovoGato.Visible = false;
                txtMicrochip.Clear();
                lblNomeGato.Text = "";
            }

            // 2. guardar no repositório de tutores
            RepositorioTutores.Atualizar(tutorAtual);

            // 3. Mensagem de Sucesso
            MessageBox.Show("Os dados do tutor foram atualizados com sucesso!");
        }
    }
}
