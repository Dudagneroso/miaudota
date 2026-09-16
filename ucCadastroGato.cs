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
    public partial class ucCadastroGato : UserControl
    {
        string caminhoFotoSelecionada = string.Empty;
        public ucCadastroGato()
        {
            InitializeComponent();
        }

        private void btnEscolherFoto_Click(object sender, EventArgs e)
        {
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                pbFotoGato.Image = Image.FromFile(ofdFoto.FileName);
                caminhoFotoSelecionada = ofdFoto.FileName;
            }
        }
    }
}
