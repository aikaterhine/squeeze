namespace Squeeze.Formulários
{
    partial class frmFaixas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaixas));
            this.dgvFaixas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAlbum = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.txtFaixa = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbArtistas = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.formSkin1 = new FlatUI.FormSkin();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaixas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFaixas
            // 
            this.dgvFaixas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaixas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nomeF,
            this.duracaoF,
            this.Album});
            this.dgvFaixas.Location = new System.Drawing.Point(12, 122);
            this.dgvFaixas.MultiSelect = false;
            this.dgvFaixas.Name = "dgvFaixas";
            this.dgvFaixas.ReadOnly = true;
            this.dgvFaixas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaixas.Size = new System.Drawing.Size(240, 240);
            this.dgvFaixas.TabIndex = 11;
            this.dgvFaixas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaixas_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // nomeF
            // 
            this.nomeF.DataPropertyName = "nome";
            this.nomeF.HeaderText = "Faixa";
            this.nomeF.Name = "nomeF";
            this.nomeF.ReadOnly = true;
            // 
            // duracaoF
            // 
            this.duracaoF.DataPropertyName = "duracao";
            this.duracaoF.HeaderText = "Duração";
            this.duracaoF.Name = "duracaoF";
            this.duracaoF.ReadOnly = true;
            // 
            // Album
            // 
            this.Album.DataPropertyName = "idalbum";
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 36);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(294, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Album:";
            // 
            // cmbAlbum
            // 
            this.cmbAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAlbum.FormattingEnabled = true;
            this.cmbAlbum.Location = new System.Drawing.Point(295, 184);
            this.cmbAlbum.Name = "cmbAlbum";
            this.cmbAlbum.Size = new System.Drawing.Size(167, 29);
            this.cmbAlbum.TabIndex = 39;
            this.cmbAlbum.SelectedValueChanged += new System.EventHandler(this.cmbAlbum_SelectedValueChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(296, 348);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(166, 28);
            this.btnCadastrar.TabIndex = 38;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(295, 291);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(167, 29);
            this.txtDuracao.TabIndex = 37;
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.BackColor = System.Drawing.Color.Transparent;
            this.lblEstudio.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEstudio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEstudio.Location = new System.Drawing.Point(294, 275);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(53, 13);
            this.lblEstudio.TabIndex = 36;
            this.lblEstudio.Text = "Duração:";
            // 
            // txtFaixa
            // 
            this.txtFaixa.Location = new System.Drawing.Point(295, 236);
            this.txtFaixa.Name = "txtFaixa";
            this.txtFaixa.Size = new System.Drawing.Size(167, 29);
            this.txtFaixa.TabIndex = 35;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAlbum.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAlbum.Location = new System.Drawing.Point(294, 220);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(40, 13);
            this.lblAlbum.TabIndex = 34;
            this.lblAlbum.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(294, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Artista:";
            // 
            // cmbArtistas
            // 
            this.cmbArtistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArtistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbArtistas.FormattingEnabled = true;
            this.cmbArtistas.Location = new System.Drawing.Point(295, 130);
            this.cmbArtistas.Name = "cmbArtistas";
            this.cmbArtistas.Size = new System.Drawing.Size(167, 29);
            this.cmbArtistas.TabIndex = 42;
            this.cmbArtistas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(297, 382);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(166, 27);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(12, 382);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(101, 27);
            this.btnConfirmar.TabIndex = 45;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(151, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 27);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.btnCancelar);
            this.formSkin1.Controls.Add(this.dgvFaixas);
            this.formSkin1.Controls.Add(this.btnConfirmar);
            this.formSkin1.Controls.Add(this.lblAlbum);
            this.formSkin1.Controls.Add(this.btnExcluir);
            this.formSkin1.Controls.Add(this.txtFaixa);
            this.formSkin1.Controls.Add(this.label2);
            this.formSkin1.Controls.Add(this.lblEstudio);
            this.formSkin1.Controls.Add(this.cmbArtistas);
            this.formSkin1.Controls.Add(this.txtDuracao);
            this.formSkin1.Controls.Add(this.pictureBox1);
            this.formSkin1.Controls.Add(this.btnCadastrar);
            this.formSkin1.Controls.Add(this.label1);
            this.formSkin1.Controls.Add(this.cmbAlbum);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(517, 436);
            this.formSkin1.TabIndex = 48;
            this.formSkin1.Text = "Faixas";
            // 
            // frmFaixas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Squeeze.Properties.Resources._32c9dec15f5b9bf92081e8ea7acb2527;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 436);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFaixas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Faixas";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaixas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFaixas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlbum;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label lblEstudio;
        private System.Windows.Forms.TextBox txtFaixa;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbArtistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeF;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaoF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private FlatUI.FormSkin formSkin1;
    }
}