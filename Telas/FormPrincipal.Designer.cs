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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCadastroTutor = new System.Windows.Forms.Button();
            this.btnCadastroGato = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.btnConsultaTutor = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnConsultaTutor);
            this.pnlMenu.Controls.Add(this.btnCadastroTutor);
            this.pnlMenu.Controls.Add(this.btnCadastroGato);
            this.pnlMenu.Controls.Add(this.btnConsulta);
            this.pnlMenu.Controls.Add(this.pbLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 770);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCadastroTutor
            // 
            this.btnCadastroTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroTutor.FlatAppearance.BorderSize = 0;
            this.btnCadastroTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroTutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnCadastroTutor.Location = new System.Drawing.Point(0, 128);
            this.btnCadastroTutor.Name = "btnCadastroTutor";
            this.btnCadastroTutor.Size = new System.Drawing.Size(200, 35);
            this.btnCadastroTutor.TabIndex = 5;
            this.btnCadastroTutor.Text = "👤 Cadastrar Tutor e Adoção";
            this.btnCadastroTutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroTutor.UseVisualStyleBackColor = true;
            this.btnCadastroTutor.Click += new System.EventHandler(this.btnCadastroTutor_Click);
            // 
            // btnCadastroGato
            // 
            this.btnCadastroGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroGato.FlatAppearance.BorderSize = 0;
            this.btnCadastroGato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroGato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnCadastroGato.Location = new System.Drawing.Point(0, 93);
            this.btnCadastroGato.Name = "btnCadastroGato";
            this.btnCadastroGato.Size = new System.Drawing.Size(200, 35);
            this.btnCadastroGato.TabIndex = 4;
            this.btnCadastroGato.Text = "🐱 Cadastrar Gato";
            this.btnCadastroGato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroGato.UseVisualStyleBackColor = true;
            this.btnCadastroGato.Click += new System.EventHandler(this.btnCadastroGato_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnConsulta.Location = new System.Drawing.Point(0, 58);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(200, 35);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "🔍 Consultar Gatos";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // pbLogo
            // 
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
            this.pnlConteudo.Size = new System.Drawing.Size(640, 770);
            this.pnlConteudo.TabIndex = 1;
            // 
            // btnConsultaTutor
            // 
            this.btnConsultaTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultaTutor.FlatAppearance.BorderSize = 0;
            this.btnConsultaTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaTutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnConsultaTutor.Location = new System.Drawing.Point(0, 163);
            this.btnConsultaTutor.Name = "btnConsultaTutor";
            this.btnConsultaTutor.Size = new System.Drawing.Size(200, 35);
            this.btnConsultaTutor.TabIndex = 6;
            this.btnConsultaTutor.Text = "📋 Consultar Tutores";
            this.btnConsultaTutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaTutor.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 770);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FormPrincipal";
            this.Text = "Miaudota";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnCadastroGato;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnCadastroTutor;
        private System.Windows.Forms.Button btnConsultaTutor;
    }
}