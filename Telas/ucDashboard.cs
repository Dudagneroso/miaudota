using Microsoft.Win32;
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
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            AtualizarIndicadoresGatos(RepositorioGatosFake.ObterTodos());
        }

        private void AtualizarIndicadoresGatos(List<Gato> gatos)
        {
            lblNumGatos.Text = gatos.Count.ToString();

            if (gatos.Count > 0)
            {
                int numGatosAdotados = gatos.Count(g => g.Status == "Adotado");
                lblQtdAdocoes.Text = numGatosAdotados.ToString();

                double mediaDias = gatos
                    .Where(g => g.Status == "Adotado" && g.Data_Adocao != null && g.DataChegadaOng != null)
                    .Average(g => (g.Data_Adocao - g.DataChegadaOng).TotalDays);
                lblTempoOng.Text = mediaDias.ToString("F0");

            }
            else
            {
                lblQtdAdocoes.Text = "0";
            }

        }

        
    }
}
