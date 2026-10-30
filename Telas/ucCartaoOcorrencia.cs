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
    public partial class ucCartaoOcorrencia : UserControl
    {
        public ucCartaoOcorrencia()
        {
            InitializeComponent();
        }

        private bool selecionado;
        public bool Selecionado
        {
            get { return selecionado; }
            set
            {
                selecionado = value;
                this.pnlFundo.BackColor = selecionado ? Color.FromArgb(255, 238, 243) : Color.White;
                this.BackColor = selecionado ? Color.FromArgb(244, 114, 150) : Color.FromArgb(255, 215, 230);
                this.lblSigla.BackColor = selecionado ? Color.FromArgb(246, 106, 142) : Color.FromArgb(238, 232, 252);
                this.lblSigla.BackColor = selecionado ? Color.FromArgb(255, 255, 255) : Color.FromArgb(150, 120, 200);
                Invalidate();
            }
        }

        public void CarregarDados(Ocorrencia ocorrencia)
        {
            lblSigla.Text = ocorrencia.Sigla;
            lblNome.Text = ocorrencia.Nome;
            lblDescricao.Text = ocorrencia.Descricao;

        }
    }
}
