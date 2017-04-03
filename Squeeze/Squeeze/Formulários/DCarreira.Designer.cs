namespace Squeeze.Formulários
{
    partial class DCarreira
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
            this.lblRef = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.cmbReferencia = new System.Windows.Forms.ComboBox();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.BackColor = System.Drawing.Color.Transparent;
            this.lblRef.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRef.ForeColor = System.Drawing.Color.White;
            this.lblRef.Location = new System.Drawing.Point(55, 83);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(230, 13);
            this.lblRef.TabIndex = 8;
            this.lblRef.Text = "As referências deverão ser substituídas por:";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(222, 50);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(99, 13);
            this.flatLabel2.TabIndex = 7;
            this.flatLabel2.Text = "Deseja continuar?";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(30, 23);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(471, 13);
            this.flatLabel1.TabIndex = 6;
            this.flatLabel1.Text = "Há referências em outras tabelas. Prosseguir com a operação resultará em perda de" +
    " dados.";
            // 
            // cmbReferencia
            // 
            this.cmbReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReferencia.FormattingEnabled = true;
            this.cmbReferencia.Location = new System.Drawing.Point(295, 76);
            this.cmbReferencia.Name = "cmbReferencia";
            this.cmbReferencia.Size = new System.Drawing.Size(182, 21);
            this.cmbReferencia.TabIndex = 9;
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(33, 154);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(184, 36);
            this.btnSim.TabIndex = 10;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNao
            // 
            this.btnNao.Location = new System.Drawing.Point(295, 154);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(184, 36);
            this.btnNao.TabIndex = 11;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(172, 112);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(184, 36);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // DCarreira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(524, 200);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.cmbReferencia);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.flatLabel2);
            this.Controls.Add(this.flatLabel1);
            this.Name = "DCarreira";
            this.Text = "DCarreira";
            this.Load += new System.EventHandler(this.DCarreira_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatLabel lblRef;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.ComboBox cmbReferencia;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Button btnConfirmar;
    }
}