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
        public event EventHandler CartaoClicado;
        private bool selecionado;
        public ucCartaoOcorrencia()
        {
            InitializeComponent();

            Click += (s, e) => CartaoClicado?.Invoke(this, EventArgs.Empty);
            foreach (Control c in Controls)
            {
                c.Click += (s, e) => CartaoClicado?.Invoke(this, EventArgs.Empty);
            }
        }

        public Ocorrencia Ocorrencia { get; private set; }

        public void CarregarDados(Ocorrencia ocorrencia)
        {
            //Ocorrencia = ocorrencia;
            lblSigla.Text = ocorrencia.Sigla;
            lblNome.Text = ocorrencia.Nome;
            lblDescricao.Text = ocorrencia.Descricao;
        }

        
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
                //Invalidate();
            }
        }
    }
}
