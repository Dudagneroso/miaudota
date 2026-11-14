namespace miaudota
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDashboards = new System.Windows.Forms.Button();
            this.btnConsultaTutor = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnOcorrencia = new System.Windows.Forms.Button();
            this.btnCadastroLar = new System.Windows.Forms.Button();
            this.btnCadastroTutor = new System.Windows.Forms.Button();
            this.btnCadastroGato = new System.Windows.Forms.Button();
            this.pnlPerfilContainer = new System.Windows.Forms.Panel();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.lblStatusGato = new System.Windows.Forms.Label();
            this.lblMicrochipGato = new System.Windows.Forms.Label();
            this.lblIdadeGato = new System.Windows.Forms.Label();
            this.lblNomeGato = new System.Windows.Forms.Label();
            this.pbFotoGato = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.pnlConteudoUsuario = new System.Windows.Forms.Panel();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblNomeOng = new System.Windows.Forms.Label();
            this.llblSair = new System.Windows.Forms.LinkLabel();
            this.pnlMenu.SuspendLayout();
            this.pnlPerfilContainer.SuspendLayout();
            this.pnlPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            this.pnlConteudoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.pnlUsuario);
            this.pnlMenu.Controls.Add(this.btnDashboards);
            this.pnlMenu.Controls.Add(this.btnConsultaTutor);
            this.pnlMenu.Controls.Add(this.btnConsulta);
            this.pnlMenu.Controls.Add(this.btnOcorrencia);
            this.pnlMenu.Controls.Add(this.btnCadastroLar);
            this.pnlMenu.Controls.Add(this.btnCadastroTutor);
            this.pnlMenu.Controls.Add(this.btnCadastroGato);
            this.pnlMenu.Controls.Add(this.pnlPerfilContainer);
            this.pnlMenu.Controls.Add(this.pbLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 810);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnDashboards
            // 
            this.btnDashboards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboards.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboards.FlatAppearance.BorderSize = 0;
            this.btnDashboards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnDashboards.Location = new System.Drawing.Point(0, 505);
            this.btnDashboards.Name = "btnDashboards";
            this.btnDashboards.Size = new System.Drawing.Size(200, 35);
            this.btnDashboards.TabIndex = 25;
            this.btnDashboards.Text = "📊 Dashboards";
            this.btnDashboards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboards.UseVisualStyleBackColor = true;
            this.btnDashboards.Click += new System.EventHandler(this.btnDashboards_Click);
            // 
            // btnConsultaTutor
            // 
            this.btnConsultaTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultaTutor.FlatAppearance.BorderSize = 0;
            this.btnConsultaTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaTutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnConsultaTutor.Location = new System.Drawing.Point(0, 470);
            this.btnConsultaTutor.Name = "btnConsultaTutor";
            this.btnConsultaTutor.Size = new System.Drawing.Size(200, 35);
            this.btnConsultaTutor.TabIndex = 24;
            this.btnConsultaTutor.Text = "📋 Consultar Tutores";
            this.btnConsultaTutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaTutor.UseVisualStyleBackColor = true;
            this.btnConsultaTutor.Click += new System.EventHandler(this.btnConsultaTutor_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnConsulta.Location = new System.Drawing.Point(0, 435);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(200, 35);
            this.btnConsulta.TabIndex = 23;
            this.btnConsulta.Text = "🔍 Consultar Gatos";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnOcorrencia
            // 
            this.btnOcorrencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcorrencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOcorrencia.FlatAppearance.BorderSize = 0;
            this.btnOcorrencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcorrencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnOcorrencia.Location = new System.Drawing.Point(0, 400);
            this.btnOcorrencia.Name = "btnOcorrencia";
            this.btnOcorrencia.Size = new System.Drawing.Size(200, 35);
            this.btnOcorrencia.TabIndex = 22;
            this.btnOcorrencia.Text = "🚨 Registrar Ocorrências";
            this.btnOcorrencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOcorrencia.UseVisualStyleBackColor = true;
            this.btnOcorrencia.Click += new System.EventHandler(this.btnOcorrencia_Click);
            // 
            // btnCadastroLar
            // 
            this.btnCadastroLar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroLar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroLar.FlatAppearance.BorderSize = 0;
            this.btnCadastroLar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroLar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroLar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnCadastroLar.Location = new System.Drawing.Point(0, 365);
            this.btnCadastroLar.Name = "btnCadastroLar";
            this.btnCadastroLar.Size = new System.Drawing.Size(200, 35);
            this.btnCadastroLar.TabIndex = 21;
            this.btnCadastroLar.Text = "🏠 Cadastrar Lar Temporário";
            this.btnCadastroLar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroLar.UseVisualStyleBackColor = true;
            this.btnCadastroLar.Click += new System.EventHandler(this.btnCadastroLar_Click);
            // 
            // btnCadastroTutor
            // 
            this.btnCadastroTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroTutor.FlatAppearance.BorderSize = 0;
            this.btnCadastroTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroTutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnCadastroTutor.Location = new System.Drawing.Point(0, 330);
            this.btnCadastroTutor.Name = "btnCadastroTutor";
            this.btnCadastroTutor.Size = new System.Drawing.Size(200, 35);
            this.btnCadastroTutor.TabIndex = 16;
            this.btnCadastroTutor.Text = "👤 Cadastrar Tutor e Adoção";
            this.btnCadastroTutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroTutor.UseVisualStyleBackColor = true;
            this.btnCadastroTutor.Click += new System.EventHandler(this.btnCadastroTutor_Click);
            // 
            // btnCadastroGato
            // 
            this.btnCadastroGato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroGato.FlatAppearance.BorderSize = 0;
            this.btnCadastroGato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroGato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnCadastroGato.Location = new System.Drawing.Point(0, 295);
            this.btnCadastroGato.Name = "btnCadastroGato";
            this.btnCadastroGato.Size = new System.Drawing.Size(200, 35);
            this.btnCadastroGato.TabIndex = 15;
            this.btnCadastroGato.Text = "🐱 Cadastrar Gato";
            this.btnCadastroGato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroGato.UseVisualStyleBackColor = true;
            this.btnCadastroGato.Click += new System.EventHandler(this.btnCadastroGato_Click);
            // 
            // pnlPerfilContainer
            // 
            this.pnlPerfilContainer.Controls.Add(this.pnlPerfil);
            this.pnlPerfilContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPerfilContainer.Location = new System.Drawing.Point(0, 58);
            this.pnlPerfilContainer.Name = "pnlPerfilContainer";
            this.pnlPerfilContainer.Padding = new System.Windows.Forms.Padding(12);
            this.pnlPerfilContainer.Size = new System.Drawing.Size(200, 237);
            this.pnlPerfilContainer.TabIndex = 14;
            this.pnlPerfilContainer.Visible = false;
            // 
            // pnlPerfil
            // 
            this.pnlPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.pnlPerfil.Controls.Add(this.lblStatusGato);
            this.pnlPerfil.Controls.Add(this.lblMicrochipGato);
            this.pnlPerfil.Controls.Add(this.lblIdadeGato);
            this.pnlPerfil.Controls.Add(this.lblNomeGato);
            this.pnlPerfil.Controls.Add(this.pbFotoGato);
            this.pnlPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPerfil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPerfil.Location = new System.Drawing.Point(12, 12);
            this.pnlPerfil.Name = "pnlPerfil";
            this.pnlPerfil.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlPerfil.Size = new System.Drawing.Size(176, 213);
            this.pnlPerfil.TabIndex = 9;
            // 
            // lblStatusGato
            // 
            this.lblStatusGato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblStatusGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatusGato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusGato.Location = new System.Drawing.Point(0, 189);
            this.lblStatusGato.Name = "lblStatusGato";
            this.lblStatusGato.Size = new System.Drawing.Size(176, 20);
            this.lblStatusGato.TabIndex = 4;
            this.lblStatusGato.Text = "Disponibilidade";
            this.lblStatusGato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMicrochipGato
            // 
            this.lblMicrochipGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMicrochipGato.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicrochipGato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.lblMicrochipGato.Location = new System.Drawing.Point(0, 159);
            this.lblMicrochipGato.Name = "lblMicrochipGato";
            this.lblMicrochipGato.Size = new System.Drawing.Size(176, 30);
            this.lblMicrochipGato.TabIndex = 3;
            this.lblMicrochipGato.Text = "Microchip";
            this.lblMicrochipGato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdadeGato
            // 
            this.lblIdadeGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIdadeGato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeGato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblIdadeGato.Location = new System.Drawing.Point(0, 139);
            this.lblIdadeGato.Name = "lblIdadeGato";
            this.lblIdadeGato.Size = new System.Drawing.Size(176, 20);
            this.lblIdadeGato.TabIndex = 2;
            this.lblIdadeGato.Text = "Idade";
            this.lblIdadeGato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeGato
            // 
            this.lblNomeGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomeGato.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.lblNomeGato.Location = new System.Drawing.Point(0, 99);
            this.lblNomeGato.Name = "lblNomeGato";
            this.lblNomeGato.Size = new System.Drawing.Size(176, 40);
            this.lblNomeGato.TabIndex = 1;
            this.lblNomeGato.Text = "Nome";
            this.lblNomeGato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFotoGato
            // 
            this.pbFotoGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbFotoGato.Location = new System.Drawing.Point(0, 5);
            this.pbFotoGato.Name = "pbFotoGato";
            this.pbFotoGato.Size = new System.Drawing.Size(176, 94);
            this.pbFotoGato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoGato.TabIndex = 0;
            this.pbFotoGato.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::miaudota.Properties.Resources.logoSemFundo2;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 58);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(200, 0);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(640, 810);
            this.pnlConteudo.TabIndex = 1;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.pnlConteudoUsuario);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 753);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.pnlUsuario.Size = new System.Drawing.Size(200, 57);
            this.pnlUsuario.TabIndex = 26;
            // 
            // pnlConteudoUsuario
            // 
            this.pnlConteudoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.pnlConteudoUsuario.Controls.Add(this.llblSair);
            this.pnlConteudoUsuario.Controls.Add(this.lblNomeOng);
            this.pnlConteudoUsuario.Controls.Add(this.lblNomeUsuario);
            this.pnlConteudoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudoUsuario.Location = new System.Drawing.Point(5, 5);
            this.pnlConteudoUsuario.Name = "pnlConteudoUsuario";
            this.pnlConteudoUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.pnlConteudoUsuario.Size = new System.Drawing.Size(190, 47);
            this.pnlConteudoUsuario.TabIndex = 0;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.lblNomeUsuario.Location = new System.Drawing.Point(7, 7);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(43, 15);
            this.lblNomeUsuario.TabIndex = 0;
            this.lblNomeUsuario.Text = "Admin";
            // 
            // lblNomeOng
            // 
            this.lblNomeOng.AutoSize = true;
            this.lblNomeOng.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomeOng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.lblNomeOng.Location = new System.Drawing.Point(7, 22);
            this.lblNomeOng.Name = "lblNomeOng";
            this.lblNomeOng.Size = new System.Drawing.Size(107, 13);
            this.lblNomeOng.TabIndex = 1;
            this.lblNomeOng.Text = "Projeto Mundo Felino";
            // 
            // llblSair
            // 
            this.llblSair.AutoSize = true;
            this.llblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblSair.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.llblSair.Location = new System.Drawing.Point(140, 9);
            this.llblSair.Name = "llblSair";
            this.llblSair.Size = new System.Drawing.Size(40, 13);
            this.llblSair.TabIndex = 2;
            this.llblSair.TabStop = true;
            this.llblSair.Text = "Sair ➡️";
            this.llblSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSair_LinkClicked);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 810);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Miaudota";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlPerfilContainer.ResumeLayout(false);
            this.pnlPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlConteudoUsuario.ResumeLayout(false);
            this.pnlConteudoUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlPerfilContainer;
        private System.Windows.Forms.Button btnCadastroTutor;
        private System.Windows.Forms.Button btnCadastroGato;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.Label lblStatusGato;
        private System.Windows.Forms.Label lblMicrochipGato;
        private System.Windows.Forms.Label lblIdadeGato;
        private System.Windows.Forms.Label lblNomeGato;
        private System.Windows.Forms.PictureBox pbFotoGato;
        private System.Windows.Forms.Button btnOcorrencia;
        private System.Windows.Forms.Button btnCadastroLar;
        private System.Windows.Forms.Button btnDashboards;
        private System.Windows.Forms.Button btnConsultaTutor;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlConteudoUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.LinkLabel llblSair;
        private System.Windows.Forms.Label lblNomeOng;
    }
}