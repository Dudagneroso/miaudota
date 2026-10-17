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
            txtEndereco.Text = tutor.Endereco;


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
    }
}
