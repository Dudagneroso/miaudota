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
    public partial class ucCadastroLar : UserControl
    {
        public ucCadastroLar()
        {
            InitializeComponent();
        }

        private void ucCadastroLar_Load(object sender, EventArgs e)
        {
            dtpInicioDisponivel.Value = DateTime.Today;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = SomenteNumeros(txtCPF.Text);
                string telefone = SomenteNumeros(txtTelefone.Text);
                string cep = SomenteNumeros(txtCEP.Text);

                if (string.IsNullOrWhiteSpace(txtNome.Text))
                    throw new InvalidOperationException("Informe o nome completo.");
                if (cpf.Length != 11)
                    throw new InvalidOperationException("O CPF deve ter 11 números.");
                if (telefone.Length < 10 || telefone.Length > 11)
                    throw new InvalidOperationException("O telefone deve ter 10 ou 11 números, com DDD.");
                if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
                    throw new InvalidOperationException("Informe um e-mail válido.");
                if (cep.Length != 8)
                    throw new InvalidOperationException("O CEP deve ter 8 números.");
                if (string.IsNullOrWhiteSpace(txtCidade.Text))
                    throw new InvalidOperationException("Informe a cidade.");
                if (txtEstado.Text.Trim().Length != 2)
                    throw new InvalidOperationException("Informe o estado com 2 letras, por exemplo SP.");
                if (string.IsNullOrWhiteSpace(txtLogradouro.Text))
                    throw new InvalidOperationException("Informe o logradouro.");
                if (string.IsNullOrWhiteSpace(txtBairro.Text))
                    throw new InvalidOperationException("Informe o bairro.");
                if (string.IsNullOrWhiteSpace(txtNumero.Text))
                    throw new InvalidOperationException("Informe o número.");
                if (cbMoradia.SelectedItem == null)
                    throw new InvalidOperationException("Selecione o tipo de moradia.");
                if (cbCapacidade.SelectedItem == null)
                    throw new InvalidOperationException("Selecione a capacidade.");
                if (cbOutrosAnimais.SelectedItem == null)
                    throw new InvalidOperationException("Informe se há outros animais na casa.");
                if (cbDisponibilidade.SelectedItem == null)
                    throw new InvalidOperationException("Selecione a disponibilidade.");
                if (dtpInicioDisponivel.Value.Date < DateTime.Today)
                    throw new InvalidOperationException("O início da disponibilidade não pode ser no passado.");

                LarTemporario lar = new LarTemporario
                {
                    NomeCompleto = txtNome.Text.Trim(),
                    Cpf = cpf,
                    Telefone = telefone,
                    Email = txtEmail.Text.Trim(),
                    Cep = cep,
                    Cidade = txtCidade.Text.Trim(),
                    Estado = txtEstado.Text.Trim().ToUpper(),
                    Logradouro = txtLogradouro.Text.Trim(),
                    Bairro = txtBairro.Text.Trim(),
                    Numero = txtNumero.Text.Trim(),
                    TipoMoradia = cbMoradia.SelectedItem.ToString(),
                    Capacidade = cbCapacidade.SelectedItem.ToString(),
                    OutrosAnimais = cbOutrosAnimais.SelectedItem.ToString(),
                    Disponibilidade = cbDisponibilidade.SelectedItem.ToString(),
                    InicioDisponivel = dtpInicioDisponivel.Value.Date,
                    Observacoes = txtObservacoes.Text.Trim()
                };

                RepositorioLaresTemporarios.Adicionar(lar);

                MessageBox.Show(
                    "Lar cadastrado com sucesso.\nPendentes de envio ao banco: "
                    + RepositorioLaresTemporarios.QuantidadePendente(),
                    "Cadastro de lar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de lar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            cbMoradia.SelectedIndex = -1;
            cbCapacidade.SelectedIndex = -1;
            cbOutrosAnimais.SelectedIndex = -1;
            cbDisponibilidade.SelectedIndex = -1;
            dtpInicioDisponivel.Value = DateTime.Today;
            txtObservacoes.Clear();
            txtNome.Focus();
        }

        private static string SomenteNumeros(string texto)
        {
            return new string(texto.Where(char.IsDigit).ToArray());
        }
    }
}