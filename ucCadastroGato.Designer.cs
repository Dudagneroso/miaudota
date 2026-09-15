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
            this.lblMicrochip = new System.Windows.Forms.Label();
            this.txtMicrochip = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbFemea = new System.Windows.Forms.RadioButton();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.lblPelagem = new System.Windows.Forms.Label();
            this.cbPelagem = new System.Windows.Forms.ComboBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblLarTemporario = new System.Windows.Forms.Label();
            this.txtLarTemporario = new System.Windows.Forms.TextBox();
            this.gbCastracao = new System.Windows.Forms.GroupBox();
            this.rbCastrado = new System.Windows.Forms.RadioButton();
            this.rbNaoCastrado = new System.Windows.Forms.RadioButton();
            this.gbVacinas = new System.Windows.Forms.GroupBox();
            this.rbVacinaNao = new System.Windows.Forms.RadioButton();
            this.rbVacinaSim = new System.Windows.Forms.RadioButton();
            this.gbSexo.SuspendLayout();
            this.gbCastracao.SuspendLayout();
            this.gbVacinas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloCadastroGato
            // 
            this.lblTituloCadastroGato.AutoSize = true;
            this.lblTituloCadastroGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroGato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloCadastroGato.Location = new System.Drawing.Point(16, 16);
            this.lblTituloCadastroGato.Name = "lblTituloCadastroGato";
            this.lblTituloCadastroGato.Size = new System.Drawing.Size(152, 20);
            this.lblTituloCadastroGato.TabIndex = 0;
            this.lblTituloCadastroGato.Text = "Cadastro de Gato";
            // 
            // lblMicrochip
            // 
            this.lblMicrochip.AutoSize = true;
            this.lblMicrochip.Location = new System.Drawing.Point(17, 56);
            this.lblMicrochip.Name = "lblMicrochip";
            this.lblMicrochip.Size = new System.Drawing.Size(110, 13);
            this.lblMicrochip.TabIndex = 1;
            this.lblMicrochip.Text = "Número do microchip:";
            // 
            // txtMicrochip
            // 
            this.txtMicrochip.Location = new System.Drawing.Point(20, 72);
            this.txtMicrochip.Multiline = true;
            this.txtMicrochip.Name = "txtMicrochip";
            this.txtMicrochip.Size = new System.Drawing.Size(148, 20);
            this.txtMicrochip.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 106);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 122);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 4;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFemea);
            this.gbSexo.Controls.Add(this.rbMacho);
            this.gbSexo.Location = new System.Drawing.Point(24, 162);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(144, 81);
            this.gbSexo.TabIndex = 6;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
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
            // lblPelagem
            // 
            this.lblPelagem.AutoSize = true;
            this.lblPelagem.Location = new System.Drawing.Point(17, 258);
            this.lblPelagem.Name = "lblPelagem";
            this.lblPelagem.Size = new System.Drawing.Size(51, 13);
            this.lblPelagem.TabIndex = 7;
            this.lblPelagem.Text = "Pelagem:";
            // 
            // cbPelagem
            // 
            this.cbPelagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbPelagem.Location = new System.Drawing.Point(20, 274);
            this.cbPelagem.Name = "cbPelagem";
            this.cbPelagem.Size = new System.Drawing.Size(148, 21);
            this.cbPelagem.TabIndex = 8;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(17, 307);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 9;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(21, 324);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(147, 20);
            this.dtpDataNascimento.TabIndex = 10;
            // 
            // lblLarTemporario
            // 
            this.lblLarTemporario.AutoSize = true;
            this.lblLarTemporario.Location = new System.Drawing.Point(17, 362);
            this.lblLarTemporario.Name = "lblLarTemporario";
            this.lblLarTemporario.Size = new System.Drawing.Size(81, 13);
            this.lblLarTemporario.TabIndex = 11;
            this.lblLarTemporario.Text = "Lar Temporário:";
            // 
            // txtLarTemporario
            // 
            this.txtLarTemporario.Location = new System.Drawing.Point(20, 378);
            this.txtLarTemporario.Multiline = true;
            this.txtLarTemporario.Name = "txtLarTemporario";
            this.txtLarTemporario.Size = new System.Drawing.Size(148, 20);
            this.txtLarTemporario.TabIndex = 12;
            // 
            // gbCastracao
            // 
            this.gbCastracao.Controls.Add(this.rbNaoCastrado);
            this.gbCastracao.Controls.Add(this.rbCastrado);
            this.gbCastracao.Location = new System.Drawing.Point(20, 422);
            this.gbCastracao.Name = "gbCastracao";
            this.gbCastracao.Size = new System.Drawing.Size(148, 72);
            this.gbCastracao.TabIndex = 13;
            this.gbCastracao.TabStop = false;
            this.gbCastracao.Text = "Já foi Castrado?";
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
            // gbVacinas
            // 
            this.gbVacinas.Controls.Add(this.rbVacinaNao);
            this.gbVacinas.Controls.Add(this.rbVacinaSim);
            this.gbVacinas.Location = new System.Drawing.Point(20, 518);
            this.gbVacinas.Name = "gbVacinas";
            this.gbVacinas.Size = new System.Drawing.Size(148, 72);
            this.gbVacinas.TabIndex = 14;
            this.gbVacinas.TabStop = false;
            this.gbVacinas.Text = "Possui vacinas em dia?";
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
            // ucCadastroGato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
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
            this.Name = "ucCadastroGato";
            this.Size = new System.Drawing.Size(603, 776);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbCastracao.ResumeLayout(false);
            this.gbCastracao.PerformLayout();
            this.gbVacinas.ResumeLayout(false);
            this.gbVacinas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCadastroGato;
        private System.Windows.Forms.Label lblMicrochip;
        private System.Windows.Forms.TextBox txtMicrochip;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbFemea;
        private System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.Label lblPelagem;
        private System.Windows.Forms.ComboBox cbPelagem;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblLarTemporario;
        private System.Windows.Forms.TextBox txtLarTemporario;
        private System.Windows.Forms.GroupBox gbCastracao;
        private System.Windows.Forms.RadioButton rbNaoCastrado;
        private System.Windows.Forms.RadioButton rbCastrado;
        private System.Windows.Forms.GroupBox gbVacinas;
        private System.Windows.Forms.RadioButton rbVacinaNao;
        private System.Windows.Forms.RadioButton rbVacinaSim;
    }
}
