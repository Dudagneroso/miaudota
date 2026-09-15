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
    public partial class ucConsulta : UserControl
    {
        public ucConsulta()
        {
            InitializeComponent();

            List<Gato> listaDeGatos = RepositorioGatosFake.ObterTodos();
            
            int indice = 0;

            foreach (Gato gatoAtual in listaDeGatos)
            {
                ucCartaoGato cartao = new ucCartaoGato();

                cartao.Dock = DockStyle.Fill;
                cartao.CarregarDados(gatoAtual);
                tlpGatos.Controls.Add(cartao, indice % 3, indice / 3);
                indice++;
            }
        }
    }
}
