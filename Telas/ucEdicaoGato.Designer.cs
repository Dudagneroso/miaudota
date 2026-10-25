namespace miaudota.Telas
{
    partial class ucEdicaoGato
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMicrochip = new System.Windows.Forms.TextBox();
            this.lblMicrochip = new System.Windows.Forms.Label();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblDescricaoPerfil = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.pnlCaracteristicas = new System.Windows.Forms.Panel();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbFemea = new System.Windows.Forms.RadioButton();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.pnlPelagem = new System.Windows.Forms.Panel();
            this.cbColoracao = new System.Windows.Forms.ComboBox();
            this.lblColoracao = new System.Windows.Forms.Label();
            this.cbPelagem = new System.Windows.Forms.ComboBox();
            this.lblPelagem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblSaudeStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlCaracteristicas.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.pnlPelagem.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblSaudeStatus);
            this.panel1.Controls.Add(this.pnlCaracteristicas);
            this.panel1.Controls.Add(this.lblCaracteristicas);
            this.panel1.Controls.Add(this.dtpDataNascimento);
            this.panel1.Controls.Add(this.lblDataNascimento);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.txtMicrochip);
            this.panel1.Controls.Add(this.lblMicrochip);
            this.panel1.Controls.Add(this.lblIdentificacao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 70);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(560, 1369);
            this.panel1.TabIndex = 0;
            // 
            // txtMicrochip
            // 
            this.txtMicrochip.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMicrochip.Location = new System.Drawing.Point(15, 61);
            this.txtMicrochip.Name = "txtMicrochip";
            this.txtMicrochip.Size = new System.Drawing.Size(530, 20);
            this.txtMicrochip.TabIndex = 2;
            // 
            // lblMicrochip
            // 
            this.lblMicrochip.AutoSize = true;
            this.lblMicrochip.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMicrochip.Location = new System.Drawing.Point(15, 43);
            this.lblMicrochip.Name = "lblMicrochip";
            this.lblMicrochip.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblMicrochip.Size = new System.Drawing.Size(110, 18);
            this.lblMicrochip.TabIndex = 1;
            this.lblMicrochip.Text = "Número do microchip:";
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIdentificacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblIdentificacao.Location = new System.Drawing.Point(15, 15);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.lblIdentificacao.Size = new System.Drawing.Size(88, 28);
            this.lblIdentificacao.TabIndex = 0;
            this.lblIdentificacao.Text = "IDENTIFICAÇÃO";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPerfil.Location = new System.Drawing.Point(33, 13);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(120, 20);
            this.lblPerfil.TabIndex = 1;
            this.lblPerfil.Text = "Perfil do Gato";
            // 
            // lblDescricaoPerfil
            // 
            this.lblDescricaoPerfil.AutoSize = true;
            this.lblDescricaoPerfil.Location = new System.Drawing.Point(34, 42);
            this.lblDescricaoPerfil.Name = "lblDescricaoPerfil";
            this.lblDescricaoPerfil.Size = new System.Drawing.Size(251, 13);
            this.lblDescricaoPerfil.TabIndex = 2;
            this.lblDescricaoPerfil.Text = "Edite os dados do gatinho e salve as alterações 😸 ";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
            this.btnExcluir.Location = new System.Drawing.Point(482, 25);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 30);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "🗑️ Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNome.Location = new System.Drawing.Point(15, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.lblNome.Size = new System.Drawing.Size(38, 28);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNome.Location = new System.Drawing.Point(15, 109);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(530, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDataNascimento.Location = new System.Drawing.Point(15, 129);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.lblDataNascimento.Size = new System.Drawing.Size(105, 28);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(15, 157);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(530, 20);
            this.dtpDataNascimento.TabIndex = 6;
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaracteristicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblCaracteristicas.Location = new System.Drawing.Point(15, 177);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblCaracteristicas.Size = new System.Drawing.Size(106, 53);
            this.lblCaracteristicas.TabIndex = 7;
            this.lblCaracteristicas.Text = "CARACTERÍSTICAS";
            // 
            // pnlCaracteristicas
            // 
            this.pnlCaracteristicas.Controls.Add(this.panel2);
            this.pnlCaracteristicas.Controls.Add(this.pnlPelagem);
            this.pnlCaracteristicas.Controls.Add(this.gbSexo);
            this.pnlCaracteristicas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCaracteristicas.Location = new System.Drawing.Point(15, 230);
            this.pnlCaracteristicas.Name = "pnlCaracteristicas";
            this.pnlCaracteristicas.Size = new System.Drawing.Size(530, 102);
            this.pnlCaracteristicas.TabIndex = 14;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFemea);
            this.gbSexo.Controls.Add(this.rbMacho);
            this.gbSexo.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbSexo.Location = new System.Drawing.Point(0, 0);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(125, 102);
            this.gbSexo.TabIndex = 9;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // rbFemea
            // 
            this.rbFemea.AutoSize = true;
            this.rbFemea.Location = new System.Drawing.Point(22, 52);
            this.rbFemea.Name = "rbFemea";
            this.rbFemea.Size = new System.Drawing.Size(60, 17);
            this.rbFemea.TabIndex = 1;
            this.rbFemea.TabStop = true;
            this.rbFemea.Text = "Femêa ";
            this.rbFemea.UseVisualStyleBackColor = true;
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Location = new System.Drawing.Point(22, 29);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(58, 17);
            this.rbMacho.TabIndex = 0;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = true;
            // 
            // pnlPelagem
            // 
            this.pnlPelagem.Controls.Add(this.cbColoracao);
            this.pnlPelagem.Controls.Add(this.lblColoracao);
            this.pnlPelagem.Controls.Add(this.cbPelagem);
            this.pnlPelagem.Controls.Add(this.lblPelagem);
            this.pnlPelagem.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPelagem.Location = new System.Drawing.Point(125, 0);
            this.pnlPelagem.Name = "pnlPelagem";
            this.pnlPelagem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlPelagem.Size = new System.Drawing.Size(198, 102);
            this.pnlPelagem.TabIndex = 12;
            // 
            // cbColoracao
            // 
            this.cbColoracao.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbColoracao.FormattingEnabled = true;
            this.cbColoracao.Items.AddRange(new object[] {
            "Preta",
            "Branca",
            "Vermelha/Laranja",
            "Cinza",
            "Marrom",
            "Tigrada",
            "Tricolor",
            "Frajola",
            "Bicolor",
            "Siamês",
            "Outros"});
            this.cbColoracao.Location = new System.Drawing.Point(5, 67);
            this.cbColoracao.Name = "cbColoracao";
            this.cbColoracao.Size = new System.Drawing.Size(188, 21);
            this.cbColoracao.TabIndex = 14;
            // 
            // lblColoracao
            // 
            this.lblColoracao.AutoSize = true;
            this.lblColoracao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblColoracao.Location = new System.Drawing.Point(5, 39);
            this.lblColoracao.Name = "lblColoracao";
            this.lblColoracao.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.lblColoracao.Size = new System.Drawing.Size(58, 28);
            this.lblColoracao.TabIndex = 13;
            this.lblColoracao.Text = "Coloração:";
            // 
            // cbPelagem
            // 
            this.cbPelagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPelagem.FormattingEnabled = true;
            this.cbPelagem.Items.AddRange(new object[] {
            "Curta",
            "Média",
            "Longa"});
            this.cbPelagem.Location = new System.Drawing.Point(5, 18);
            this.cbPelagem.Name = "cbPelagem";
            this.cbPelagem.Size = new System.Drawing.Size(188, 21);
            this.cbPelagem.TabIndex = 12;
            // 
            // lblPelagem
            // 
            this.lblPelagem.AutoSize = true;
            this.lblPelagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPelagem.Location = new System.Drawing.Point(5, 0);
            this.lblPelagem.Name = "lblPelagem";
            this.lblPelagem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPelagem.Size = new System.Drawing.Size(51, 18);
            this.lblPelagem.TabIndex = 11;
            this.lblPelagem.Text = "Pelagem:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbPeso);
            this.panel2.Controls.Add(this.lblPeso);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(323, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel2.Size = new System.Drawing.Size(200, 102);
            this.panel2.TabIndex = 13;
            // 
            // txbPeso
            // 
            this.txbPeso.Dock = System.Windows.Forms.DockStyle.Top;
            this.txbPeso.Location = new System.Drawing.Point(5, 18);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(190, 20);
            this.txbPeso.TabIndex = 1;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPeso.Location = new System.Drawing.Point(5, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPeso.Size = new System.Drawing.Size(56, 18);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso (Kg):";
            // 
            // lblSaudeStatus
            // 
            this.lblSaudeStatus.AutoSize = true;
            this.lblSaudeStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSaudeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblSaudeStatus.Location = new System.Drawing.Point(15, 332);
            this.lblSaudeStatus.Name = "lblSaudeStatus";
            this.lblSaudeStatus.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblSaudeStatus.Size = new System.Drawing.Size(100, 53);
            this.lblSaudeStatus.TabIndex = 15;
            this.lblSaudeStatus.Text = "SAÚDE E STATUS";
            // 
            // ucEdicaoGato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblDescricaoPerfil);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucEdicaoGato";
            this.Padding = new System.Windows.Forms.Padding(30, 70, 30, 0);
            this.Size = new System.Drawing.Size(620, 1439);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCaracteristicas.ResumeLayout(false);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.pnlPelagem.ResumeLayout(false);
            this.pnlPelagem.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblDescricaoPerfil;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblIdentificacao;
        private System.Windows.Forms.TextBox txtMicrochip;
        private System.Windows.Forms.Label lblMicrochip;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSaudeStatus;
        private System.Windows.Forms.Panel pnlCaracteristicas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Panel pnlPelagem;
        private System.Windows.Forms.ComboBox cbColoracao;
        private System.Windows.Forms.Label lblColoracao;
        private System.Windows.Forms.ComboBox cbPelagem;
        private System.Windows.Forms.Label lblPelagem;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbFemea;
        private System.Windows.Forms.RadioButton rbMacho;
    }
}
