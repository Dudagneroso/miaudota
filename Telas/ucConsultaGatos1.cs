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
    public partial class ucConsultaGatos1 : UserControl
    {
        public ucConsultaGatos1()
        {
            InitializeComponent();
        }

        private List<Gato> todosGatos = new List<Gato>();

        private void dgvGatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ucEdicaoGato tela = new ucEdicaoGato();
                Gato gatoSelecionado = (Gato)dgvGatos.Rows[e.RowIndex].DataBoundItem;
                FormPrincipal principal = (FormPrincipal)this.ParentForm;
                principal.AbrirTela(tela);
                principal.MostrarPerfilGato(gatoSelecionado);
                tela.CarregarGato(gatoSelecionado);
                
            }
        }

        private void ucConsultaGatos1_Load(object sender, EventArgs e)
        {
            try
            {
                dgvGatos.RowTemplate.Height = 60;
                dgvGatos.DataError += dgvGatos_DataError;

                todosGatos = RepositorioGatos.ObterTodos();

                cbFiltroGatos.SelectedIndex = 0;
                AplicarFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os gatos: " + ex.Message);
            }
        }

        private void ConfigurarColunas()
        {
            // colunas que não devem aparecer
            string[] ocultas = { "Id", "IdLarTemporario", "Latitude", "Longitude", "CaminhoFoto" };

            foreach (string nome in ocultas)
            {
                if (dgvGatos.Columns[nome] != null)
                {
                    dgvGatos.Columns[nome].Visible = false;
                }

                dgvGatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                foreach (DataGridViewColumn coluna in dgvGatos.Columns)
                {
                    if (!coluna.Visible) continue;

                    coluna.MinimumWidth = 90;   // abaixo disso aparece a barra horizontal
                    coluna.FillWeight = 100;    // peso padrão da coluna
                }

                // a foto mantém largura fixa
                if (dgvGatos.Columns["Foto"] != null)
                {
                    dgvGatos.Columns["Foto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvGatos.Columns["Foto"].Width = 80;
                    dgvGatos.Columns["Foto"].MinimumWidth = 80;
                }

                // colunas de texto maiores ganham mais espaço
                if (dgvGatos.Columns["Nome"] != null)
                    dgvGatos.Columns["Nome"].FillWeight = 150;

                if (dgvGatos.Columns["Observacoes"] != null)
                    dgvGatos.Columns["Observacoes"].FillWeight = 200;
            }

            // foto na primeira coluna, com imagem padrão para gatos sem foto
            DataGridViewImageColumn colunaFoto = dgvGatos.Columns["Foto"] as DataGridViewImageColumn;

            if (colunaFoto != null)
            {
                colunaFoto.HeaderText = "Foto";
                colunaFoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
                colunaFoto.DefaultCellStyle.NullValue = Properties.Resources.sem_foto;
                colunaFoto.Width = 80;
                colunaFoto.DisplayIndex = 0;
            }

            // microchip e nome logo depois da foto
            if (dgvGatos.Columns["NumeroMicrochip"] != null)
            {
                dgvGatos.Columns["NumeroMicrochip"].HeaderText = "Microchip";
                dgvGatos.Columns["NumeroMicrochip"].DisplayIndex = 1;
            }

            if (dgvGatos.Columns["Nome"] != null)
            {
                dgvGatos.Columns["Nome"].DisplayIndex = 2;
            }
        }

        private void AplicarFiltro()
        {
            string filtro = (cbFiltroGatos.Text ?? "").ToLower();
            IEnumerable<Gato> filtrados = todosGatos;

            if (filtro.Contains("adotad"))
            {
                filtrados = todosGatos.Where(g => g.Status == "Adotado");
            }
            else if (filtro.Contains("dispon"))
            {
                filtrados = todosGatos.Where(g => g.Status == "Disponível");
            }

            dgvGatos.DataSource = filtrados.ToList();
            ConfigurarColunas();
        }

        private void dgvGatos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // evita a janela de erro se alguma foto estiver corrompida
            e.ThrowException = false;
        }

        private void cbFiltroGatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }
    }
}
