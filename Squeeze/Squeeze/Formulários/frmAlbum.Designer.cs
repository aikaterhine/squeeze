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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlbum));
            this.dgvAlbum = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formSkin1 = new FlatUI.FormSkin();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.cmbArtista = new System.Windows.Forms.ComboBox();
            this.lblLancamento = new System.Windows.Forms.Label();
            this.dtmLancamento = new System.Windows.Forms.DateTimePicker();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.txtEstudio = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            this.formSkin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Estudio,
            this.Data});
            this.dgvAlbum.Location = new System.Drawing.Point(22, 119);
            this.dgvAlbum.MultiSelect = false;
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.ReadOnly = true;
            this.dgvAlbum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbum.Size = new System.Drawing.Size(240, 228);
            this.dgvAlbum.TabIndex = 13;
            this.dgvAlbum.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbum_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "idalbum";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Estudio
            // 
            this.Estudio.DataPropertyName = "estudio";
            this.Estudio.HeaderText = "Estudio";
            this.Estudio.Name = "Estudio";
            this.Estudio.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "dt";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.dgvAlbum);
            this.formSkin1.Controls.Add(this.btnConfirmar);
            this.formSkin1.Controls.Add(this.btnCancelar);
            this.formSkin1.Controls.Add(this.pictureBox1);
            this.formSkin1.Controls.Add(this.label1);
            this.formSkin1.Controls.Add(this.btnExcluir);
            this.formSkin1.Controls.Add(this.btnCadastrar);
            this.formSkin1.Controls.Add(this.lblAlbum);
            this.formSkin1.Controls.Add(this.txtAlbum);
            this.formSkin1.Controls.Add(this.cmbArtista);
            this.formSkin1.Controls.Add(this.lblLancamento);
            this.formSkin1.Controls.Add(this.dtmLancamento);
            this.formSkin1.Controls.Add(this.lblEstudio);
            this.formSkin1.Controls.Add(this.txtEstudio);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(507, 430);
            this.formSkin1.TabIndex = 50;
            this.formSkin1.Text = "Album";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(22, 382);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(101, 34);
            this.btnConfirmar.TabIndex = 47;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(161, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 34);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(309, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Artista:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(311, 392);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(166, 29);
            this.btnExcluir.TabIndex = 34;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(312, 359);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(166, 27);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAlbum.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAlbum.Location = new System.Drawing.Point(313, 166);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(43, 13);
            this.lblAlbum.TabIndex = 0;
            this.lblAlbum.Text = "Album:";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(312, 182);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(167, 29);
            this.txtAlbum.TabIndex = 1;
            // 
            // cmbArtista
            // 
            this.cmbArtista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArtista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbArtista.FormattingEnabled = true;
            this.cmbArtista.Location = new System.Drawing.Point(311, 118);
            this.cmbArtista.Name = "cmbArtista";
            this.cmbArtista.Size = new System.Drawing.Size(167, 29);
            this.cmbArtista.TabIndex = 11;
            // 
            // lblLancamento
            // 
            this.lblLancamento.AutoSize = true;
            this.lblLancamento.BackColor = System.Drawing.Color.Transparent;
            this.lblLancamento.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLancamento.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLancamento.Location = new System.Drawing.Point(310, 295);
            this.lblLancamento.Name = "lblLancamento";
            this.lblLancamento.Size = new System.Drawing.Size(72, 13);
            this.lblLancamento.TabIndex = 4;
            this.lblLancamento.Text = "Lançamento:";
            // 
            // dtmLancamento
            // 
            this.dtmLancamento.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dtmLancamento.Location = new System.Drawing.Point(311, 311);
            this.dtmLancamento.Name = "dtmLancamento";
            this.dtmLancamento.Size = new System.Drawing.Size(167, 22);
            this.dtmLancamento.TabIndex = 5;
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.BackColor = System.Drawing.Color.Transparent;
            this.lblEstudio.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEstudio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEstudio.Location = new System.Drawing.Point(309, 232);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(49, 13);
            this.lblEstudio.TabIndex = 2;
            this.lblEstudio.Text = "Estúdio:";
            // 
            // txtEstudio
            // 
            this.txtEstudio.Location = new System.Drawing.Point(311, 246);
            this.txtEstudio.Name = "txtEstudio";
            this.txtEstudio.Size = new System.Drawing.Size(167, 29);
            this.txtEstudio.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(22, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 36);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // frmAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 430);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Albuns";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private FlatUI.FormSkin formSkin1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.ComboBox cmbArtista;
        private System.Windows.Forms.Label lblLancamento;
        private System.Windows.Forms.DateTimePicker dtmLancamento;
        private System.Windows.Forms.Label lblEstudio;
        private System.Windows.Forms.TextBox txtEstudio;
    }
}