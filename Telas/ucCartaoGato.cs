using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Idade idade = Idade.Calcular(gato, DateTime.Today);

            lblNome.Text = gato.Nome;
            lblIdade.Text = $"🎂 Idade: {idade}";
            lblSexo.Text = $"🐾 Sexo: {gato.Sexo}";
            lblPelagem.Text = $"🚿 Pelagem: {gato.Coloracao}";
            lblMicrochip.Text = $"💉 Microchip: {gato.NumeroMicrochip}";
            Image fotoAnterior = pbFoto.Image;

            if (gato.Foto != null && gato.Foto.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(gato.Foto))
                using (Image img = Image.FromStream(ms))
                {
                    pbFoto.Image = new Bitmap(img);
                }
            }
            else
            {
                pbFoto.Image = Properties.Resources.sem_foto;
            }

            // libera a foto anterior, menos a imagem padrão dos recursos
            if (fotoAnterior != null && fotoAnterior != Properties.Resources.sem_foto)
            {
                fotoAnterior.Dispose();
            }

        }
    }
}
