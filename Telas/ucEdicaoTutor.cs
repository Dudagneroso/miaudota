using MySql.Data.MySqlClient;
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
    public partial class ucEdicaoTutor : UserControl
    {
        private Tutor tutorAtual;
        public ucEdicaoTutor()
        {
            InitializeComponent();
        }

        private void RecarregarGatosDoBanco()
        {
            tutorAtual.Gatos.Clear();

            foreach (Gato adotado in RepositorioGatos.ObterAdotadosPorTutor(tutorAtual.Id))
            {
                tutorAtual.Gatos.Add(adotado);
            }

            AtualizarGatosAdotados();
        }

        public void CarregarTutor(Tutor tutor)
        {
            lblNomeTutor.Text = tutor.Nome;
            lblEmailTutor.Text = tutor.Email;
            txtNome.Text = tutor.Nome;
            txtCPF.Text = tutor.CPF;
            dtpDataNascimento.Value = tutor.DataNascimento;
            txtEmail.Text = tutor.Email;
            txtTelefone.Text = tutor.Telefone;
            txtCep.Text = tutor.CEP;
            txtCidade.Text = tutor.Cidade;
            txtEstado.Text = tutor.Estado;
            txtLogradouro.Text = tutor.Logradouro;
            txtBairro.Text = tutor.Bairro;
            txtNumero.Text = tutor.Numero.ToString();
            cbTipoMoradia.Text = tutor.TipoResidencia;
            cbPets.Text = tutor.OutrosAnimais;
            tutorAtual = tutor;

            RecarregarGatosDoBanco();
        }

        private void AtualizarGatosAdotados()
        {
            flpGatos.Controls.Clear();
            foreach (var gato in tutorAtual.Gatos)
            {
                ucCartaoGato cartao = new ucCartaoGato();

                cartao.CarregarDados(gato);
                flpGatos.Controls.Add(cartao);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNovoGato.Visible = !pnlNovoGato.Visible;
        }

        Gato gatoParaVincular = null;

        private void txtMicrochip_TextChanged(object sender, EventArgs e)
        {
            Gato gato = RepositorioGatos.ObterPorMicrochip(txtMicrochip.Text.Trim());

            gatoParaVincular = null;

            if (string.IsNullOrWhiteSpace(txtMicrochip.Text))
            {
                lblNomeGato.Text = "";
                return;
            }


            if (gato == null)
            {
                lblNomeGato.Text = "Gato não encontrado";
                return;
            }

            if (gato.Status != "Disponível")
            {
                lblNomeGato.Text = "Este gato não está disponível";
                return;
            }

            lblNomeGato.Text = "Nome: " + gato.Nome;
            gatoParaVincular = gato;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja excluir este tutor?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                RepositorioTutores.Excluir(tutorAtual);

                MessageBox.Show("Tutor excluído com sucesso!");

                ((FormPrincipal)this.ParentForm).AbrirTela(new ucConsultaTutor());
            }
        }

        private void btnSalvarTutor_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. atualizar o objeto com os dados da tela
                tutorAtual.Nome = txtNome.Text;
                tutorAtual.CPF = txtCPF.Text;
                tutorAtual.Telefone = txtTelefone.Text;
                tutorAtual.DataNascimento = dtpDataNascimento.Value;
                tutorAtual.Email = txtEmail.Text;
                tutorAtual.CEP = txtCep.Text;
                tutorAtual.Cidade = txtCidade.Text;
                tutorAtual.Estado = txtEstado.Text;
                tutorAtual.Logradouro = txtLogradouro.Text;
                tutorAtual.Bairro = txtBairro.Text;
                tutorAtual.Numero = int.Parse(txtNumero.Text);
                tutorAtual.TipoResidencia = cbTipoMoradia.Text;
                tutorAtual.OutrosAnimais = cbPets.Text;

                // 2. gravar os dados do tutor no banco
                RepositorioTutores.Atualizar(tutorAtual);

                // 3. gravar a adoção, se houver gato para vincular
                if (gatoParaVincular != null)
                {
                    RepositorioTutores.AdotarGato(tutorAtual, gatoParaVincular);
                    tutorAtual.DataAdocao = DateTime.Today;
                    gatoParaVincular = null;

                    RecarregarGatosDoBanco();

                    pnlNovoGato.Visible = false;
                    txtMicrochip.Clear();
                    lblNomeGato.Text = "";
                }

                MessageBox.Show("Os dados do tutor foram atualizados com sucesso!");
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
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Já existe um tutor cadastrado com esse CPF.", "CPF duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
