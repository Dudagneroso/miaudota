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

            foreach (var gato in tutor.Gatos)
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
            Gato gato = RepositorioGatosFake.ObterTodos().FirstOrDefault(g => g.NumeroMicrochip == txtMicrochip.Text.Trim());

            if (gato != null)
            {
                lblNomeGato.Text = "Nome: " + gato.Nome;
                gatoParaVincular = gato;

            }
            else
            {
                lblNomeGato.Text = "Gato não encontrado";
                gatoParaVincular = null;

            }
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
                RepositorioTutoresFake.Excluir(tutorAtual);

                MessageBox.Show("Tutor excluído com sucesso!");

                ((FormPrincipal)this.ParentForm).AbrirTela(new ucConsultaTutor());
            }
        }

        private void btnSalvarTutor_Click(object sender, EventArgs e)
        {
            // 1. montar o objeto Tutor com os dados da tela
            Tutor tutor = new Tutor
            {
                Nome = txtNome.Text,
                CPF = txtCPF.Text,
                Telefone = txtTelefone.Text,
                DataNascimento = dtpDataNascimento.Value,
                Email = txtEmail.Text,
                CEP = txtCep.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                Logradouro = txtLogradouro.Text,
                Bairro = txtBairro.Text,
                Numero = int.Parse(txtNumero.Text),
                TipoResidencia = cbTipoMoradia.SelectedItem?.ToString(),
                OutrosAnimais = cbPets.SelectedItem?.ToString(),
            };

            // 2. guardar no repositório de tutores
            RepositorioTutoresFake.Atualizar(tutor);

            // 3. Mensagem de Sucesso
            MessageBox.Show("Os dados do tutor foram atualizados com sucesso!");
        }
    }
}
