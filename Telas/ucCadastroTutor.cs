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
    public partial class ucCadastroTutor : UserControl
    {
        public ucCadastroTutor()
        {
            InitializeComponent();

            dgvGatos.DataSource = RepositorioGatosFake.ObterTodos();
        }

        private void dgvGatos_SelectionChanged(object sender, EventArgs e)
        {
            lblGatoSelecionado.Text = $"Gato selecionado: {dgvGatos.CurrentRow?.Cells["Nome"].Value} | Microchip: {dgvGatos.CurrentRow?.Cells["NumeroMicrochip"].Value}";
        }
    }
}
