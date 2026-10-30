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
    public partial class ucOcorrencia : UserControl
    {
        public ucOcorrencia()
        {
            InitializeComponent();

            List<Ocorrencia> tipos = TiposOcorrencia.ObterTodos();
            int indice = 0;

            foreach (Ocorrencia tipo in tipos)
            {
                ucCartaoOcorrencia cartao = new ucCartaoOcorrencia();
                cartao.CarregarDados(tipo);
                cartao.Dock = DockStyle.Fill;
                cartao.Margin = new Padding(6);
                //cartao.Selecionado += SelecionarCartao;

                //coluna = indice % 3, linha = indice / 3
                tlpTipos.Controls.Add(cartao, indice % 3, indice / 3);

                indice++;
            }
        }

        
    }
}
