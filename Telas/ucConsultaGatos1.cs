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
    public partial class ucConsultaGatos1 : UserControl
    {
        public ucConsultaGatos1()
        {
            InitializeComponent();
        }

        private void dgvGatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ucEdicaoGato tela = new ucEdicaoGato();
                Gato gatoSelecionado = (Gato)dgvGatos.Rows[e.RowIndex].DataBoundItem;
                FormPrincipal principal = (FormPrincipal)this.ParentForm;
                principal.AbrirTela(tela);
                principal.MostrarPerfilGato(gatoSelecionado);
                tela.CarregarGato(gatoSelecionado);
                
            }
        }

        private void ucConsultaGatos1_Load(object sender, EventArgs e)
        {
            cbFiltroGatos.SelectedIndex = 0;
            dgvGatos.DataSource = RepositorioGatos.ObterTodos();
            dgvGatos.RowTemplate.Height = 60;
        }
    }
}
