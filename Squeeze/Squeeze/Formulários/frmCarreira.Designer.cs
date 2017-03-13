namespace Squeeze.Formulários
{
    partial class frmCarreira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarreira));
            this.lblCarreira = new System.Windows.Forms.Label();
            this.txtCarreira = new System.Windows.Forms.TextBox();
            this.dgvCarreira = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarreira
            // 
            this.lblCarreira.AutoSize = true;
            this.lblCarreira.BackColor = System.Drawing.Color.Transparent;
            this.lblCarreira.ForeColor = System.Drawing.Color.Transparent;
            this.lblCarreira.Location = new System.Drawing.Point(57, 73);
            this.lblCarreira.Name = "lblCarreira";
            this.lblCarreira.Size = new System.Drawing.Size(85, 13);
            this.lblCarreira.TabIndex = 0;
            this.lblCarreira.Text = "Carreira Musical:";
            // 
            // txtCarreira
            // 
            this.txtCarreira.Location = new System.Drawing.Point(60, 89);
            this.txtCarreira.Name = "txtCarreira";
            this.txtCarreira.Size = new System.Drawing.Size(134, 20);
            this.txtCarreira.TabIndex = 1;
            // 
            // dgvCarreira
            // 
            this.dgvCarreira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreira.Location = new System.Drawing.Point(60, 129);
            this.dgvCarreira.Name = "dgvCarreira";
            this.dgvCarreira.Size = new System.Drawing.Size(244, 112);
            this.dgvCarreira.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(60, 261);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 30);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(192, 261);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(112, 30);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 36);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmCarreira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Squeeze.Properties.Resources._32c9dec15f5b9bf92081e8ea7acb2527;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 304);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvCarreira);
            this.Controls.Add(this.txtCarreira);
            this.Controls.Add(this.lblCarreira);
            this.Name = "frmCarreira";
            this.Text = "Carreira Musical";
            this.Load += new System.EventHandler(this.frmCarreira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarreira;
        private System.Windows.Forms.TextBox txtCarreira;
        private System.Windows.Forms.DataGridView dgvCarreira;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}