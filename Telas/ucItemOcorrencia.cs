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
    public partial class ucItemOcorrencia : UserControl
    {
        public ucItemOcorrencia()
        {
            InitializeComponent();
        }

        public void CarregarDados(OcorrenciaGato ocorrencia)
        {
            lblTipo.Text = ocorrencia.Tipo;
            lblData.Text = ocorrencia.Data.ToString("dd/MM/yyyy");
            lblLocalResponsavel.Text = $"{ocorrencia.Local} . {ocorrencia.Responsavel}";
            lblDescricao.Text = ocorrencia.Descricao;

            switch (ocorrencia.Tipo)
            {
                case "Devolução": 
                    lblSigla.Text = "DV"; 
                    break;
                case "Abandono": 
                    lblSigla.Text = "AB"; 
                    break;
                case "Fuga": 
                    lblSigla.Text = "RL"; 
                    break;
                case "Internação": 
                    lblSigla.Text = "IN"; 
                    break;
                case "Óbito":
                    lblSigla.Text = "OB";
                    break;
            }
        }
    }
}
