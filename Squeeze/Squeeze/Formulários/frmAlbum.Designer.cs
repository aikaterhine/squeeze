﻿namespace Squeeze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlbum));
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtEstudio = new System.Windows.Forms.TextBox();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.lblLancamento = new System.Windows.Forms.Label();
            this.dtmLancamento = new System.Windows.Forms.DateTimePicker();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbArtista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlbum = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lblAlbum.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAlbum.Location = new System.Drawing.Point(311, 135);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(39, 13);
            this.lblAlbum.TabIndex = 0;
            this.lblAlbum.Text = "Album:";
            this.lblAlbum.Click += new System.EventHandler(this.lblAlbum_Click);
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(312, 149);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(167, 20);
            this.txtAlbum.TabIndex = 1;
            this.txtAlbum.TextChanged += new System.EventHandler(this.txtAlbum_TextChanged);
            // 
            // txtEstudio
            // 
            this.txtEstudio.Location = new System.Drawing.Point(312, 204);
            this.txtEstudio.Name = "txtEstudio";
            this.txtEstudio.Size = new System.Drawing.Size(167, 20);
            this.txtEstudio.TabIndex = 3;
            this.txtEstudio.TextChanged += new System.EventHandler(this.txtEstudio_TextChanged);
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.BackColor = System.Drawing.Color.Transparent;
            this.lblEstudio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEstudio.Location = new System.Drawing.Point(311, 191);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(45, 13);
            this.lblEstudio.TabIndex = 2;
            this.lblEstudio.Text = "Estúdio:";
            this.lblEstudio.Click += new System.EventHandler(this.lblEstudio_Click);
            // 
            // lblLancamento
            // 
            this.lblLancamento.AutoSize = true;
            this.lblLancamento.BackColor = System.Drawing.Color.Transparent;
            this.lblLancamento.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLancamento.Location = new System.Drawing.Point(311, 241);
            this.lblLancamento.Name = "lblLancamento";
            this.lblLancamento.Size = new System.Drawing.Size(69, 13);
            this.lblLancamento.TabIndex = 4;
            this.lblLancamento.Text = "Lançamento:";
            this.lblLancamento.Click += new System.EventHandler(this.lblLancamento_Click);
            // 
            // dtmLancamento
            // 
            this.dtmLancamento.Location = new System.Drawing.Point(312, 257);
            this.dtmLancamento.Name = "dtmLancamento";
            this.dtmLancamento.Size = new System.Drawing.Size(167, 20);
            this.dtmLancamento.TabIndex = 5;
            this.dtmLancamento.ValueChanged += new System.EventHandler(this.dtmLancamento_ValueChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(313, 303);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(166, 25);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbArtista
            // 
            this.cmbArtista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArtista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbArtista.FormattingEnabled = true;
            this.cmbArtista.Location = new System.Drawing.Point(312, 101);
            this.cmbArtista.Name = "cmbArtista";
            this.cmbArtista.Size = new System.Drawing.Size(167, 21);
            this.cmbArtista.TabIndex = 11;
            this.cmbArtista.SelectedIndexChanged += new System.EventHandler(this.cmbArtista_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(311, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Artista:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Estudio});
            this.dgvAlbum.Location = new System.Drawing.Point(23, 84);
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.Size = new System.Drawing.Size(240, 245);
            this.dgvAlbum.TabIndex = 13;
            this.dgvAlbum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbum_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Estudio
            // 
            this.Estudio.DataPropertyName = "estudio";
            this.Estudio.HeaderText = "Estudio";
            this.Estudio.Name = "Estudio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 36);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Squeeze.Properties.Resources._32c9dec15f5b9bf92081e8ea7acb2527;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 356);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAlbum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbArtista);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtmLancamento);
            this.Controls.Add(this.lblLancamento);
            this.Controls.Add(this.txtEstudio);
            this.Controls.Add(this.lblEstudio);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.lblAlbum);
            this.Name = "frmAlbum";
            this.Text = "Cadastro de Albuns";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbArtista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}