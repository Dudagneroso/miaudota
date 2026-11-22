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
        }

        private List<Gato> todosGatos = new List<Gato>();
        private bool carregando = true;

        private void ucConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                todosGatos = RepositorioGatos.ObterTodos().Where(g => g.Status == "Disponível").ToList();

                cbxFiltro.SelectedIndex = 0;
                carregando = false;

                AplicarFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os gatos: " + ex.Message);
            }
        }

        private void ExibirCards(List<Gato> gatos)
        {
            tlpGatos.SuspendLayout();

            // remove e libera os cards anteriores
            foreach (Control controle in tlpGatos.Controls.Cast<Control>().ToList())
            {
                tlpGatos.Controls.Remove(controle);
                controle.Dispose();
            }

            tlpGatos.RowCount = Math.Max(1, (int)Math.Ceiling(gatos.Count / 3.0));

            int indice = 0;

            foreach (Gato gatoAtual in gatos)
            {
                ucCartaoGato cartao = new ucCartaoGato();

                cartao.Dock = DockStyle.Fill;
                cartao.CarregarDados(gatoAtual);
                tlpGatos.Controls.Add(cartao, indice % 3, indice / 3);
                indice++;
            }

            tlpGatos.ResumeLayout();
        }

        private void AplicarFiltro()
        {
            string filtro = (cbxFiltro.Text ?? "").ToLower();
            IEnumerable<Gato> ordenados = todosGatos;

            if (filtro.Contains("recent"))
            {
                // últimos adicionados primeiro (o Id cresce a cada cadastro)
                ordenados = todosGatos.OrderByDescending(g => g.Id);
            }
            else if (filtro.Contains("temp"))
            {
                // mais tempo na ONG primeiro (data de entrada mais antiga)
                ordenados = todosGatos.OrderBy(g => g.DataChegadaOng);
            }
            else if (filtro.Contains("idad"))
            {
                ordenados = todosGatos
                    .OrderBy(g => g.DataNascimento == DateTime.MinValue)
                    .ThenBy(g => g.DataNascimento);
            }

            ExibirCards(ordenados.ToList());
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carregando)
            {
                AplicarFiltro();
            }
        }
    }
}
