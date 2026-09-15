using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miaudota
{
    public partial class ucCartaoGato : UserControl
    {
        public ucCartaoGato()
        {
            InitializeComponent();
        }

        public void CarregarDados(Gato gato)
        {
            lblNome.Text = gato.Nome;
            lblIdade.Text = $"Idade: {gato.Idade}";
            lblSexo.Text = $"Sexo: {gato.Sexo}";
            lblPelagem.Text = $"Pelagem: {gato.Pelagem}";
            lblMicrochip.Text = $"Microchip: {gato.NumeroMicrochip}";
            string caminho = gato.CaminhoFoto;

            if (string.IsNullOrEmpty(caminho))
            {
                pbFoto.Image = Properties.Resources.sem_foto;
            }
            else
            {
                pbFoto.Image = Image.FromFile(caminho);
            }
        }
    }
}
