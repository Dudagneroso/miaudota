using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
