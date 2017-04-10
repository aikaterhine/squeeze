namespace Squeeze.Formulários
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.formSkin1 = new FlatUI.FormSkin();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpPreferencias = new System.Windows.Forms.GroupBox();
            this.clbPreferencias = new System.Windows.Forms.CheckedListBox();
            this.btnSal = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.formSkin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpPreferencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSenha.Location = new System.Drawing.Point(76, 183);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(183, 29);
            this.txtSenha.TabIndex = 25;
            this.txtSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Location = new System.Drawing.Point(76, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 29);
            this.txtEmail.TabIndex = 26;
            this.txtEmail.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNome.Location = new System.Drawing.Point(76, 100);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(183, 29);
            this.txtNome.TabIndex = 24;
            this.txtNome.Text = "Nome";
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.txtSenha);
            this.formSkin1.Controls.Add(this.pictureBox1);
            this.formSkin1.Controls.Add(this.txtEmail);
            this.formSkin1.Controls.Add(this.gpPreferencias);
            this.formSkin1.Controls.Add(this.txtNome);
            this.formSkin1.Controls.Add(this.btnSal);
            this.formSkin1.Controls.Add(this.btnCancelar);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(332, 399);
            this.formSkin1.TabIndex = 33;
            this.formSkin1.Text = "Cadastre-se";
            this.formSkin1.Click += new System.EventHandler(this.formSkin1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 36);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // gpPreferencias
            // 
            this.gpPreferencias.BackColor = System.Drawing.Color.Transparent;
            this.gpPreferencias.Controls.Add(this.clbPreferencias);
            this.gpPreferencias.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gpPreferencias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpPreferencias.Location = new System.Drawing.Point(76, 230);
            this.gpPreferencias.Name = "gpPreferencias";
            this.gpPreferencias.Size = new System.Drawing.Size(178, 102);
            this.gpPreferencias.TabIndex = 31;
            this.gpPreferencias.TabStop = false;
            this.gpPreferencias.Text = "Preferências Musicais";
            // 
            // clbPreferencias
            // 
            this.clbPreferencias.BackColor = System.Drawing.SystemColors.Info;
            this.clbPreferencias.FormattingEnabled = true;
            this.clbPreferencias.Location = new System.Drawing.Point(6, 21);
            this.clbPreferencias.Name = "clbPreferencias";
            this.clbPreferencias.Size = new System.Drawing.Size(167, 72);
            this.clbPreferencias.TabIndex = 0;
            // 
            // btnSal
            // 
            this.btnSal.BackColor = System.Drawing.Color.Transparent;
            this.btnSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSal.Location = new System.Drawing.Point(74, 338);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(79, 34);
            this.btnSal.TabIndex = 27;
            this.btnSal.Text = "Salvar";
            this.btnSal.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(173, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 34);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Squeeze.Properties.Resources._32c9dec15f5b9bf92081e8ea7acb2527;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 399);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUsuario";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpPreferencias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private FlatUI.FormSkin formSkin1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpPreferencias;
        private System.Windows.Forms.CheckedListBox clbPreferencias;
        private System.Windows.Forms.Button btnSal;
        private System.Windows.Forms.Button btnCancelar;
    }
}