using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miaudota.Telas
{
    public partial class ucCadastroTutor : UserControl
    {
        public ucCadastroTutor()
        {
            InitializeComponent();
            Load += ucCadastroTutor_Load;
            //dgvGatos.DataSource = RepositorioGatosFake.ObterTodos();
        }

        private void CarregarGatos()
        {
            try
            {
                dgvGatos.DataSource = RepositorioGatos.ObterDisponiveis();

                if (dgvGatos.Columns["Id"] != null)
                {
                    dgvGatos.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os gatos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGatos_SelectionChanged(object sender, EventArgs e)
        {
            lblGatoSelecionado.Text = $"Gato selecionado: {dgvGatos.CurrentRow?.Cells["Nome"].Value} | Microchip: {dgvGatos.CurrentRow?.Cells["NumeroMicrochip"].Value}";
        }
        private void LimparFormulario()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            txtEmail.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            cbTipoMoradia.SelectedIndex = -1;
            cbPets.SelectedIndex = -1;

        }

        private void btnSalvarTutor_Click(object sender, EventArgs e)
        {
            try
            {
                Gato gatoSelecionado = dgvGatos.CurrentRow?.DataBoundItem as Gato;


                // 1. montar o objeto Tutor com os dados da tela
                Tutor tutor = new Tutor
                {
                    Nome = txtNome.Text,
                    CPF = txtCPF.Text,
                    Telefone = txtTelefone.Text,
                    DataNascimento = dtpDataNascimento.Value,
                    Email = txtEmail.Text,
                    CEP = txtCep.Text,
                    Cidade = txtCidade.Text,
                    Estado = txtEstado.Text,
                    Logradouro = txtLogradouro.Text,
                    Bairro = txtBairro.Text,
                    Numero = int.Parse(txtNumero.Text),
                    TipoResidencia = cbTipoMoradia.SelectedItem?.ToString(),
                    OutrosAnimais = cbPets.SelectedItem?.ToString(),
                };

                tutor.AdotarGato(gatoSelecionado);

                // 2. guardar no repositório de tutores
                RepositorioTutores.Adicionar(tutor, gatoSelecionado);

                // 3. Mensagem de Sucesso
                MessageBox.Show("Tutor cadastrado com sucesso!");

                // 4. limpar o formulário
                LimparFormulario();
                CarregarGatos();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Já existe um tutor cadastrado com esse CPF.", "CPF duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Número inválido. Por favor, insira um número válido.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Adoção não permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void ucCadastroTutor_Load(object sender, EventArgs e)
        {
            CarregarGatos();
        }
    }
}
