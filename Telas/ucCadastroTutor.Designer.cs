namespace miaudota.Telas
{
    partial class ucCadastroTutor
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloCadastroTutor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblGatosDisponiveis = new System.Windows.Forms.Label();
            this.btnSalvarTutor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvGatos = new System.Windows.Forms.DataGridView();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.lblGatoSelecionado = new System.Windows.Forms.Label();
            this.lblVinculoAdocao = new System.Windows.Forms.Label();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCadastroTutor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGatos)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloCadastroTutor
            // 
            this.lblTituloCadastroTutor.AutoSize = true;
            this.lblTituloCadastroTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroTutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloCadastroTutor.Location = new System.Drawing.Point(18, 14);
            this.lblTituloCadastroTutor.Name = "lblTituloCadastroTutor";
            this.lblTituloCadastroTutor.Size = new System.Drawing.Size(154, 20);
            this.lblTituloCadastroTutor.TabIndex = 1;
            this.lblTituloCadastroTutor.Text = "Cadastro de Tutor";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 86);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 102);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(538, 25);
            this.txtNome.TabIndex = 5;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(29, 142);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(32, 158);
            this.txtCPF.Multiline = true;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(538, 25);
            this.txtCPF.TabIndex = 7;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(33, 220);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(537, 20);
            this.dtpDataNascimento.TabIndex = 12;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(29, 203);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 11;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(33, 276);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(538, 25);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 260);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(32, 335);
            this.txtTelefone.Multiline = true;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(538, 25);
            this.txtTelefone.TabIndex = 16;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(29, 319);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 15;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblGatosDisponiveis
            // 
            this.lblGatosDisponiveis.AutoSize = true;
            this.lblGatosDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGatosDisponiveis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGatosDisponiveis.Location = new System.Drawing.Point(27, 455);
            this.lblGatosDisponiveis.Name = "lblGatosDisponiveis";
            this.lblGatosDisponiveis.Size = new System.Drawing.Size(162, 20);
            this.lblGatosDisponiveis.TabIndex = 17;
            this.lblGatosDisponiveis.Text = "🩵 Vincular Adoção";
            // 
            // btnSalvarTutor
            // 
            this.btnSalvarTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(201)))), ((int)(((byte)(200)))));
            this.btnSalvarTutor.FlatAppearance.BorderSize = 0;
            this.btnSalvarTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarTutor.Location = new System.Drawing.Point(371, 901);
            this.btnSalvarTutor.Name = "btnSalvarTutor";
            this.btnSalvarTutor.Size = new System.Drawing.Size(200, 30);
            this.btnSalvarTutor.TabIndex = 23;
            this.btnSalvarTutor.Text = "Salvar";
            this.btnSalvarTutor.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlPesquisa);
            this.panel1.Location = new System.Drawing.Point(30, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 302);
            this.panel1.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvGatos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 241);
            this.panel3.TabIndex = 1;
            // 
            // dgvGatos
            // 
            this.dgvGatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGatos.Location = new System.Drawing.Point(0, 0);
            this.dgvGatos.MultiSelect = false;
            this.dgvGatos.Name = "dgvGatos";
            this.dgvGatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGatos.Size = new System.Drawing.Size(538, 241);
            this.dgvGatos.TabIndex = 0;
            this.dgvGatos.SelectionChanged += new System.EventHandler(this.dgvGatos_SelectionChanged);
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Controls.Add(this.txtPesquisa);
            this.pnlPesquisa.Controls.Add(this.lblPesquisar);
            this.pnlPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPesquisa.Location = new System.Drawing.Point(0, 0);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(538, 61);
            this.pnlPesquisa.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(1, 26);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(538, 25);
            this.txtPesquisa.TabIndex = 18;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(-2, 10);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 17;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // lblGatoSelecionado
            // 
            this.lblGatoSelecionado.AutoSize = true;
            this.lblGatoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGatoSelecionado.Location = new System.Drawing.Point(27, 847);
            this.lblGatoSelecionado.Name = "lblGatoSelecionado";
            this.lblGatoSelecionado.Size = new System.Drawing.Size(181, 18);
            this.lblGatoSelecionado.TabIndex = 25;
            this.lblGatoSelecionado.Text = "Nenhum gato selecionado";
            // 
            // lblVinculoAdocao
            // 
            this.lblVinculoAdocao.AutoSize = true;
            this.lblVinculoAdocao.Location = new System.Drawing.Point(28, 487);
            this.lblVinculoAdocao.Name = "lblVinculoAdocao";
            this.lblVinculoAdocao.Size = new System.Drawing.Size(267, 13);
            this.lblVinculoAdocao.TabIndex = 26;
            this.lblVinculoAdocao.Text = "Selecione um gato disponível para vincular a este tutor";
            // 
            // txtEndereço
            // 
            this.txtEndereço.Location = new System.Drawing.Point(31, 392);
            this.txtEndereço.Multiline = true;
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(538, 25);
            this.txtEndereço.TabIndex = 28;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(28, 376);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 27;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCadastroTutor
            // 
            this.lblCadastroTutor.AutoSize = true;
            this.lblCadastroTutor.Location = new System.Drawing.Point(19, 43);
            this.lblCadastroTutor.Name = "lblCadastroTutor";
            this.lblCadastroTutor.Size = new System.Drawing.Size(190, 13);
            this.lblCadastroTutor.TabIndex = 29;
            this.lblCadastroTutor.Text = "Dados do responsável pela adoção 👤";
            // 
            // ucCadastroTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.lblCadastroTutor);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblVinculoAdocao);
            this.Controls.Add(this.lblGatoSelecionado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvarTutor);
            this.Controls.Add(this.lblGatosDisponiveis);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTituloCadastroTutor);
            this.Name = "ucCadastroTutor";
            this.Size = new System.Drawing.Size(614, 949);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGatos)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCadastroTutor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblGatosDisponiveis;
        private System.Windows.Forms.Button btnSalvarTutor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvGatos;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label lblGatoSelecionado;
        private System.Windows.Forms.Label lblVinculoAdocao;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCadastroTutor;
    }
}
