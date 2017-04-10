namespace Squeeze.Formulários
{
    partial class DGenero
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.btnSim = new System.Windows.Forms.Button();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.cmbReferencia = new System.Windows.Forms.ComboBox();
            this.lblRef = new FlatUI.FlatLabel();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.btnConfirmar);
            this.formSkin1.Controls.Add(this.btnNao);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.btnSim);
            this.formSkin1.Controls.Add(this.flatLabel2);
            this.formSkin1.Controls.Add(this.cmbReferencia);
            this.formSkin1.Controls.Add(this.lblRef);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(524, 268);
            this.formSkin1.TabIndex = 21;
            this.formSkin1.Text = "Alerta";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(168, 167);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(184, 36);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnNao
            // 
            this.btnNao.BackColor = System.Drawing.Color.Transparent;
            this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNao.Location = new System.Drawing.Point(291, 209);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(184, 36);
            this.btnNao.TabIndex = 18;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(26, 78);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(471, 13);
            this.flatLabel1.TabIndex = 13;
            this.flatLabel1.Text = "Há referências em outras tabelas. Prosseguir com a operação resultará em perda de" +
    " dados.";
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.Color.Transparent;
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSim.Location = new System.Drawing.Point(29, 209);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(184, 36);
            this.btnSim.TabIndex = 17;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = false;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(218, 105);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(99, 13);
            this.flatLabel2.TabIndex = 14;
            this.flatLabel2.Text = "Deseja continuar?";
            // 
            // cmbReferencia
            // 
            this.cmbReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReferencia.FormattingEnabled = true;
            this.cmbReferencia.Location = new System.Drawing.Point(291, 131);
            this.cmbReferencia.Name = "cmbReferencia";
            this.cmbReferencia.Size = new System.Drawing.Size(182, 29);
            this.cmbReferencia.TabIndex = 16;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.BackColor = System.Drawing.Color.Transparent;
            this.lblRef.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRef.ForeColor = System.Drawing.Color.White;
            this.lblRef.Location = new System.Drawing.Point(51, 138);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(230, 13);
            this.lblRef.TabIndex = 15;
            this.lblRef.Text = "As referências deverão ser substituídas por:";
            // 
            // DGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(524, 268);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DGenero";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnNao;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.Button btnSim;
        private FlatUI.FlatLabel flatLabel2;
        private System.Windows.Forms.ComboBox cmbReferencia;
        private FlatUI.FlatLabel lblRef;
    }
}