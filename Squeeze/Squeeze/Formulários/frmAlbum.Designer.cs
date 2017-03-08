namespace Squeeze
{
    partial class frmAlbum
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
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtEstudio = new System.Windows.Forms.TextBox();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.lblLancamento = new System.Windows.Forms.Label();
            this.dtmLancamento = new System.Windows.Forms.DateTimePicker();
            this.lblDimensoes = new System.Windows.Forms.Label();
            this.cmbDimensoes = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lblAlbum.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAlbum.Location = new System.Drawing.Point(21, 27);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(39, 13);
            this.lblAlbum.TabIndex = 0;
            this.lblAlbum.Text = "Album:";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(75, 24);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(167, 20);
            this.txtAlbum.TabIndex = 1;
            // 
            // txtEstudio
            // 
            this.txtEstudio.Location = new System.Drawing.Point(75, 79);
            this.txtEstudio.Name = "txtEstudio";
            this.txtEstudio.Size = new System.Drawing.Size(167, 20);
            this.txtEstudio.TabIndex = 3;
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.BackColor = System.Drawing.Color.Transparent;
            this.lblEstudio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEstudio.Location = new System.Drawing.Point(21, 82);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(45, 13);
            this.lblEstudio.TabIndex = 2;
            this.lblEstudio.Text = "Estúdio:";
            // 
            // lblLancamento
            // 
            this.lblLancamento.AutoSize = true;
            this.lblLancamento.BackColor = System.Drawing.Color.Transparent;
            this.lblLancamento.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLancamento.Location = new System.Drawing.Point(19, 134);
            this.lblLancamento.Name = "lblLancamento";
            this.lblLancamento.Size = new System.Drawing.Size(69, 13);
            this.lblLancamento.TabIndex = 4;
            this.lblLancamento.Text = "Lançamento:";
            // 
            // dtmLancamento
            // 
            this.dtmLancamento.Location = new System.Drawing.Point(99, 132);
            this.dtmLancamento.Name = "dtmLancamento";
            this.dtmLancamento.Size = new System.Drawing.Size(143, 20);
            this.dtmLancamento.TabIndex = 5;
            // 
            // lblDimensoes
            // 
            this.lblDimensoes.AutoSize = true;
            this.lblDimensoes.BackColor = System.Drawing.Color.Transparent;
            this.lblDimensoes.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDimensoes.Location = new System.Drawing.Point(19, 186);
            this.lblDimensoes.Name = "lblDimensoes";
            this.lblDimensoes.Size = new System.Drawing.Size(62, 13);
            this.lblDimensoes.TabIndex = 6;
            this.lblDimensoes.Text = "Dimensões:";
            // 
            // cmbDimensoes
            // 
            this.cmbDimensoes.FormattingEnabled = true;
            this.cmbDimensoes.Items.AddRange(new object[] {
            "400x600",
            "1450x389",
            "500x300"});
            this.cmbDimensoes.Location = new System.Drawing.Point(99, 178);
            this.cmbDimensoes.Name = "cmbDimensoes";
            this.cmbDimensoes.Size = new System.Drawing.Size(143, 21);
            this.cmbDimensoes.TabIndex = 8;
            this.cmbDimensoes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(118, 225);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(113, 25);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeF,
            this.duracaoF});
            this.dataGridView1.Location = new System.Drawing.Point(343, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 220);
            this.dataGridView1.TabIndex = 10;
            // 
            // nomeF
            // 
            this.nomeF.DataPropertyName = "nomeF";
            this.nomeF.HeaderText = "Faixa";
            this.nomeF.Name = "nomeF";
            // 
            // duracaoF
            // 
            this.duracaoF.DataPropertyName = "duracaoF";
            this.duracaoF.HeaderText = "Duração";
            this.duracaoF.Name = "duracaoF";
            // 
            // frmAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Squeeze.Properties.Resources._32c9dec15f5b9bf92081e8ea7acb2527;
            this.ClientSize = new System.Drawing.Size(616, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cmbDimensoes);
            this.Controls.Add(this.lblDimensoes);
            this.Controls.Add(this.dtmLancamento);
            this.Controls.Add(this.lblLancamento);
            this.Controls.Add(this.txtEstudio);
            this.Controls.Add(this.lblEstudio);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.lblAlbum);
            this.Name = "frmAlbum";
            this.Text = "Cadastro de Albuns";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtEstudio;
        private System.Windows.Forms.Label lblEstudio;
        private System.Windows.Forms.Label lblLancamento;
        private System.Windows.Forms.DateTimePicker dtmLancamento;
        private System.Windows.Forms.Label lblDimensoes;
        private System.Windows.Forms.ComboBox cmbDimensoes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeF;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaoF;
    }
}