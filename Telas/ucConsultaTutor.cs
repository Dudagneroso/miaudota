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
    public partial class ucConsultaTutor : UserControl
    {
        public ucConsultaTutor()
        {
            InitializeComponent();
            Load += ucConsultaTutor_Load;
        }

        private void dgvTutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ucEdicaoTutor tela = new ucEdicaoTutor();
                Tutor tutorSelecionado =(Tutor)dgvTutores.Rows[e.RowIndex].DataBoundItem;
                tela.CarregarTutor(tutorSelecionado);
                ((FormPrincipal)this.ParentForm).AbrirTela(tela);

            }
        }

        private void ucConsultaTutor_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTutores.RowTemplate.Height = 60;
                dgvTutores.DataError += dgvTutores_DataError;
                dgvTutores.DataSource = RepositorioTutores.ObterTodos();
                ConfigurarColunas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os tutores: " + ex.Message);
            }
        }

        private void ConfigurarColunas()
        {
            // colunas que não devem aparecer
            string[] ocultas = { "Id", "Gatos", "DataAdocao" };

            foreach (string nome in ocultas)
            {
                if (dgvTutores.Columns[nome] != null)
                {
                    dgvTutores.Columns[nome].Visible = false;
                }
            }

            // cabeçalhos mais amigáveis
            TrocarCabecalho("CPF", "CPF");
            TrocarCabecalho("DataNascimento", "Nascimento");
            TrocarCabecalho("CEP", "CEP");
            TrocarCabecalho("TipoResidencia", "Moradia");
            TrocarCabecalho("OutrosAnimais", "Outros pets");

            // colunas dividem a largura disponível
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn coluna in dgvTutores.Columns)
            {
                if (!coluna.Visible) continue;

                coluna.MinimumWidth = 90;
                coluna.FillWeight = 100;
            }

            // colunas de texto maiores ganham mais espaço
            DefinirPeso("Nome", 160);
            DefinirPeso("Email", 160);
            DefinirPeso("Logradouro", 150);

            // colunas curtas ficam mais estreitas
            DefinirPeso("Numero", 60);
            DefinirPeso("Estado", 60);
        }

        private void TrocarCabecalho(string coluna, string titulo)
        {
            if (dgvTutores.Columns[coluna] != null)
            {
                dgvTutores.Columns[coluna].HeaderText = titulo;
            }
        }

        private void DefinirPeso(string coluna, float peso)
        {
            if (dgvTutores.Columns[coluna] != null)
            {
                dgvTutores.Columns[coluna].FillWeight = peso;
            }
        }

        private void dgvTutores_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
