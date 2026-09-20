using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using miaudota.Telas;

namespace miaudota
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirTela(UserControl tela)
        {
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
            AbrirTela(new ucCadastroGato());
        }

        private void btnCadastroTutor_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucCadastroTutor());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucConsultaGatos1());
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucConsulta());
        }
    }
}
