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

            dgvGatos.DataSource = RepositorioGatosFake.ObterTodos();
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
            //Atualizar infos do gato
            Gato gatoSelecionado = dgvGatos.CurrentRow?.DataBoundItem as Gato;
            gatoSelecionado.Data_Adocao = DateTime.Now;
            gatoSelecionado.Status =  "Adotado";

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
                Gatos = new List<Gato> { gatoSelecionado },
                DataAdocao = DateTime.Now
            };

            // 2. guardar no repositório de tutores
            RepositorioTutoresFake.Adicionar(tutor);

            // 3. Mensagem de Sucesso
            MessageBox.Show("Tutor cadastrado com sucesso!");

            // 4. limpar o formulário
            LimparFormulario();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

    }
}
