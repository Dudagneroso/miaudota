namespace miaudota
{
    partial class ucCadastroGato
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
            this.lblTituloCadastroGato = new System.Windows.Forms.Label();
            this.lblDeficiencias = new System.Windows.Forms.Label();
            this.txtDeficiencias = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEscolherFoto = new System.Windows.Forms.Label();
            this.btnEscolherFoto = new System.Windows.Forms.Button();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvarGato = new System.Windows.Forms.Button();
            this.pbFotoGato = new System.Windows.Forms.PictureBox();
            this.lblMicrochip = new System.Windows.Forms.Label();
            this.txtMicrochip = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.rbFemea = new System.Windows.Forms.RadioButton();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.lblPelagem = new System.Windows.Forms.Label();
            this.cbPelagem = new System.Windows.Forms.ComboBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblLarTemporario = new System.Windows.Forms.Label();
            this.txtLarTemporario = new System.Windows.Forms.TextBox();
            this.rbCastrado = new System.Windows.Forms.RadioButton();
            this.rbNaoCastrado = new System.Windows.Forms.RadioButton();
            this.gbCastracao = new System.Windows.Forms.GroupBox();
            this.rbVacinaSim = new System.Windows.Forms.RadioButton();
            this.rbVacinaNao = new System.Windows.Forms.RadioButton();
            this.gbVacinas = new System.Windows.Forms.GroupBox();
            this.pnlCadastroGato = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGato)).BeginInit();
            this.gbSexo.SuspendLayout();
            this.gbCastracao.SuspendLayout();
            this.gbVacinas.SuspendLayout();
            this.pnlCadastroGato.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloCadastroGato
            // 
            this.lblTituloCadastroGato.AutoSize = true;
            this.lblTituloCadastroGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroGato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloCadastroGato.Location = new System.Drawing.Point(16, 16);
            this.lblTituloCadastroGato.Name = "lblTituloCadastroGato";
            this.lblTituloCadastroGato.Size = new System.Drawing.Size(133, 20);
            this.lblTituloCadastroGato.TabIndex = 0;
            this.lblTituloCadastroGato.Text = "Cadastrar Gato";
            // 
            // lblDeficiencias
            // 
            this.lblDeficiencias.AutoSize = true;
            this.lblDeficiencias.BackColor = System.Drawing.Color.White;
            this.lblDeficiencias.Location = new System.Drawing.Point(30, 601);
            this.lblDeficiencias.Name = "lblDeficiencias";
            this.lblDeficiencias.Size = new System.Drawing.Size(189, 13);
            this.lblDeficiencias.TabIndex = 15;
            this.lblDeficiencias.Text = "Possui alguma doença ou deficiência?";
            // 
            // txtDeficiencias
            // 
            this.txtDeficiencias.Location = new System.Drawing.Point(33, 617);
            this.txtDeficiencias.Multiline = true;
            this.txtDeficiencias.Name = "txtDeficiencias";
            this.txtDeficiencias.Size = new System.Drawing.Size(538, 25);
            this.txtDeficiencias.TabIndex = 16;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.White;
            this.lblObservacao.Location = new System.Drawing.Point(30, 653);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(73, 13);
            this.lblObservacao.TabIndex = 17;
            this.lblObservacao.Text = "Observações:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 669);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(538, 79);
            this.textBox1.TabIndex = 18;
            // 
            // lblEscolherFoto
            // 
            this.lblEscolherFoto.AutoSize = true;
            this.lblEscolherFoto.BackColor = System.Drawing.Color.White;
            this.lblEscolherFoto.Location = new System.Drawing.Point(9, 769);
            this.lblEscolherFoto.Name = "lblEscolherFoto";
            this.lblEscolherFoto.Size = new System.Drawing.Size(72, 13);
            this.lblEscolherFoto.TabIndex = 20;
            this.lblEscolherFoto.Text = "Foto do Gato:";
            // 
            // btnEscolherFoto
            // 
            this.btnEscolherFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(201)))), ((int)(((byte)(200)))));
            this.btnEscolherFoto.FlatAppearance.BorderSize = 0;
            this.btnEscolherFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolherFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolherFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEscolherFoto.Location = new System.Drawing.Point(12, 893);
            this.btnEscolherFoto.Name = "btnEscolherFoto";
            this.btnEscolherFoto.Size = new System.Drawing.Size(200, 30);
            this.btnEscolherFoto.TabIndex = 21;
            this.btnEscolherFoto.Text = "Escolher Foto";
            this.btnEscolherFoto.UseVisualStyleBackColor = false;
            this.btnEscolherFoto.Click += new System.EventHandler(this.btnEscolherFoto_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            this.ofdFoto.Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            // 
            // btnSalvarGato
            // 
            this.btnSalvarGato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(201)))), ((int)(((byte)(200)))));
            this.btnSalvarGato.FlatAppearance.BorderSize = 0;
            this.btnSalvarGato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarGato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarGato.Location = new System.Drawing.Point(350, 951);
            this.btnSalvarGato.Name = "btnSalvarGato";
            this.btnSalvarGato.Size = new System.Drawing.Size(200, 30);
            this.btnSalvarGato.TabIndex = 22;
            this.btnSalvarGato.Text = "Salvar";
            this.btnSalvarGato.UseVisualStyleBackColor = false;
            // 
            // pbFotoGato
            // 
            this.pbFotoGato.BackColor = System.Drawing.Color.White;
            this.pbFotoGato.Location = new System.Drawing.Point(12, 785);
            this.pbFotoGato.Name = "pbFotoGato";
            this.pbFotoGato.Size = new System.Drawing.Size(197, 102);
            this.pbFotoGato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoGato.TabIndex = 19;
            this.pbFotoGato.TabStop = false;
            // 
            // lblMicrochip
            // 
            this.lblMicrochip.AutoSize = true;
            this.lblMicrochip.BackColor = System.Drawing.Color.White;
            this.lblMicrochip.Location = new System.Drawing.Point(29, 59);
            this.lblMicrochip.Name = "lblMicrochip";
            this.lblMicrochip.Size = new System.Drawing.Size(110, 13);
            this.lblMicrochip.TabIndex = 1;
            this.lblMicrochip.Text = "Número do microchip:";
            // 
            // txtMicrochip
            // 
            this.txtMicrochip.Location = new System.Drawing.Point(32, 75);
            this.txtMicrochip.Multiline = true;
            this.txtMicrochip.Name = "txtMicrochip";
            this.txtMicrochip.Size = new System.Drawing.Size(538, 25);
            this.txtMicrochip.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(29, 109);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 125);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(538, 25);
            this.txtNome.TabIndex = 4;
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Location = new System.Drawing.Point(16, 24);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(58, 17);
            this.rbMacho.TabIndex = 0;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = true;
            // 
            // rbFemea
            // 
            this.rbFemea.AutoSize = true;
            this.rbFemea.Location = new System.Drawing.Point(16, 47);
            this.rbFemea.Name = "rbFemea";
            this.rbFemea.Size = new System.Drawing.Size(57, 17);
            this.rbFemea.TabIndex = 1;
            this.rbFemea.TabStop = true;
            this.rbFemea.Text = "Femêa";
            this.rbFemea.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.BackColor = System.Drawing.Color.White;
            this.gbSexo.Controls.Add(this.rbFemea);
            this.gbSexo.Controls.Add(this.rbMacho);
            this.gbSexo.Location = new System.Drawing.Point(33, 165);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(537, 75);
            this.gbSexo.TabIndex = 6;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // lblPelagem
            // 
            this.lblPelagem.AutoSize = true;
            this.lblPelagem.BackColor = System.Drawing.Color.White;
            this.lblPelagem.Location = new System.Drawing.Point(29, 254);
            this.lblPelagem.Name = "lblPelagem";
            this.lblPelagem.Size = new System.Drawing.Size(51, 13);
            this.lblPelagem.TabIndex = 7;
            this.lblPelagem.Text = "Pelagem:";
            // 
            // cbPelagem
            // 
            this.cbPelagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPelagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPelagem.FormattingEnabled = true;
            this.cbPelagem.Items.AddRange(new object[] {
            "Preta",
            "Branca",
            "Vermelha/Laranja",
            "Cinza",
            "Marrom",
            "Tigrada",
            "Tricolor",
            "Frajola",
            "Bicolor"});
            this.cbPelagem.Location = new System.Drawing.Point(32, 270);
            this.cbPelagem.Name = "cbPelagem";
            this.cbPelagem.Size = new System.Drawing.Size(538, 24);
            this.cbPelagem.TabIndex = 8;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.Color.White;
            this.lblDataNascimento.Location = new System.Drawing.Point(29, 303);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 9;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(33, 320);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(537, 20);
            this.dtpDataNascimento.TabIndex = 10;
            // 
            // lblLarTemporario
            // 
            this.lblLarTemporario.AutoSize = true;
            this.lblLarTemporario.BackColor = System.Drawing.Color.White;
            this.lblLarTemporario.Location = new System.Drawing.Point(29, 358);
            this.lblLarTemporario.Name = "lblLarTemporario";
            this.lblLarTemporario.Size = new System.Drawing.Size(81, 13);
            this.lblLarTemporario.TabIndex = 11;
            this.lblLarTemporario.Text = "Lar Temporário:";
            // 
            // txtLarTemporario
            // 
            this.txtLarTemporario.Location = new System.Drawing.Point(32, 374);
            this.txtLarTemporario.Multiline = true;
            this.txtLarTemporario.Name = "txtLarTemporario";
            this.txtLarTemporario.Size = new System.Drawing.Size(538, 25);
            this.txtLarTemporario.TabIndex = 12;
            // 
            // rbCastrado
            // 
            this.rbCastrado.AutoSize = true;
            this.rbCastrado.Location = new System.Drawing.Point(18, 22);
            this.rbCastrado.Name = "rbCastrado";
            this.rbCastrado.Size = new System.Drawing.Size(42, 17);
            this.rbCastrado.TabIndex = 0;
            this.rbCastrado.TabStop = true;
            this.rbCastrado.Text = "Sim";
            this.rbCastrado.UseVisualStyleBackColor = true;
            // 
            // rbNaoCastrado
            // 
            this.rbNaoCastrado.AutoSize = true;
            this.rbNaoCastrado.Location = new System.Drawing.Point(18, 45);
            this.rbNaoCastrado.Name = "rbNaoCastrado";
            this.rbNaoCastrado.Size = new System.Drawing.Size(45, 17);
            this.rbNaoCastrado.TabIndex = 1;
            this.rbNaoCastrado.TabStop = true;
            this.rbNaoCastrado.Text = "Não";
            this.rbNaoCastrado.UseVisualStyleBackColor = true;
            // 
            // gbCastracao
            // 
            this.gbCastracao.BackColor = System.Drawing.Color.White;
            this.gbCastracao.Controls.Add(this.rbNaoCastrado);
            this.gbCastracao.Controls.Add(this.rbCastrado);
            this.gbCastracao.Location = new System.Drawing.Point(32, 418);
            this.gbCastracao.Name = "gbCastracao";
            this.gbCastracao.Size = new System.Drawing.Size(538, 72);
            this.gbCastracao.TabIndex = 13;
            this.gbCastracao.TabStop = false;
            this.gbCastracao.Text = "Já foi Castrado?";
            // 
            // rbVacinaSim
            // 
            this.rbVacinaSim.AutoSize = true;
            this.rbVacinaSim.Location = new System.Drawing.Point(18, 22);
            this.rbVacinaSim.Name = "rbVacinaSim";
            this.rbVacinaSim.Size = new System.Drawing.Size(42, 17);
            this.rbVacinaSim.TabIndex = 0;
            this.rbVacinaSim.TabStop = true;
            this.rbVacinaSim.Text = "Sim";
            this.rbVacinaSim.UseVisualStyleBackColor = true;
            // 
            // rbVacinaNao
            // 
            this.rbVacinaNao.AutoSize = true;
            this.rbVacinaNao.Location = new System.Drawing.Point(18, 45);
            this.rbVacinaNao.Name = "rbVacinaNao";
            this.rbVacinaNao.Size = new System.Drawing.Size(45, 17);
            this.rbVacinaNao.TabIndex = 1;
            this.rbVacinaNao.TabStop = true;
            this.rbVacinaNao.Text = "Não";
            this.rbVacinaNao.UseVisualStyleBackColor = true;
            // 
            // gbVacinas
            // 
            this.gbVacinas.BackColor = System.Drawing.Color.White;
            this.gbVacinas.Controls.Add(this.rbVacinaNao);
            this.gbVacinas.Controls.Add(this.rbVacinaSim);
            this.gbVacinas.Location = new System.Drawing.Point(32, 514);
            this.gbVacinas.Name = "gbVacinas";
            this.gbVacinas.Size = new System.Drawing.Size(538, 72);
            this.gbVacinas.TabIndex = 14;
            this.gbVacinas.TabStop = false;
            this.gbVacinas.Text = "Possui vacinas em dia?";
            // 
            // pnlCadastroGato
            // 
            this.pnlCadastroGato.BackColor = System.Drawing.Color.White;
            this.pnlCadastroGato.Controls.Add(this.lblSatus);
            this.pnlCadastroGato.Controls.Add(this.comboBox1);
            this.pnlCadastroGato.Controls.Add(this.btnEscolherFoto);
            this.pnlCadastroGato.Controls.Add(this.btnSalvarGato);
            this.pnlCadastroGato.Controls.Add(this.lblEscolherFoto);
            this.pnlCadastroGato.Controls.Add(this.pbFotoGato);
            this.pnlCadastroGato.Location = new System.Drawing.Point(20, 50);
            this.pnlCadastroGato.Name = "pnlCadastroGato";
            this.pnlCadastroGato.Size = new System.Drawing.Size(575, 1009);
            this.pnlCadastroGato.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Disponível",
            "Adotado"});
            this.comboBox1.Location = new System.Drawing.Point(12, 726);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(538, 23);
            this.comboBox1.TabIndex = 23;
            // 
            // lblSatus
            // 
            this.lblSatus.AutoSize = true;
            this.lblSatus.Location = new System.Drawing.Point(10, 710);
            this.lblSatus.Name = "lblSatus";
            this.lblSatus.Size = new System.Drawing.Size(40, 13);
            this.lblSatus.TabIndex = 24;
            this.lblSatus.Text = "Status:";
            // 
            // ucCadastroGato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtDeficiencias);
            this.Controls.Add(this.lblDeficiencias);
            this.Controls.Add(this.gbVacinas);
            this.Controls.Add(this.gbCastracao);
            this.Controls.Add(this.txtLarTemporario);
            this.Controls.Add(this.lblLarTemporario);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.cbPelagem);
            this.Controls.Add(this.lblPelagem);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtMicrochip);
            this.Controls.Add(this.lblMicrochip);
            this.Controls.Add(this.lblTituloCadastroGato);
            this.Controls.Add(this.pnlCadastroGato);
            this.Name = "ucCadastroGato";
            this.Size = new System.Drawing.Size(620, 1078);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGato)).EndInit();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbCastracao.ResumeLayout(false);
            this.gbCastracao.PerformLayout();
            this.gbVacinas.ResumeLayout(false);
            this.gbVacinas.PerformLayout();
            this.pnlCadastroGato.ResumeLayout(false);
            this.pnlCadastroGato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCadastroGato;
        private System.Windows.Forms.Label lblDeficiencias;
        private System.Windows.Forms.TextBox txtDeficiencias;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbFotoGato;
        private System.Windows.Forms.Label lblEscolherFoto;
        private System.Windows.Forms.Button btnEscolherFoto;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Button btnSalvarGato;
        private System.Windows.Forms.Label lblMicrochip;
        private System.Windows.Forms.TextBox txtMicrochip;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.RadioButton rbFemea;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.Label lblPelagem;
        private System.Windows.Forms.ComboBox cbPelagem;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblLarTemporario;
        private System.Windows.Forms.TextBox txtLarTemporario;
        private System.Windows.Forms.RadioButton rbCastrado;
        private System.Windows.Forms.RadioButton rbNaoCastrado;
        private System.Windows.Forms.GroupBox gbCastracao;
        private System.Windows.Forms.RadioButton rbVacinaSim;
        private System.Windows.Forms.RadioButton rbVacinaNao;
        private System.Windows.Forms.GroupBox gbVacinas;
        private System.Windows.Forms.Panel pnlCadastroGato;
        private System.Windows.Forms.Label lblSatus;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
