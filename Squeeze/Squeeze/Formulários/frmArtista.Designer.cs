namespace Squeeze
{
    partial class frmArtista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtista));
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvArtista = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cmbCarreira = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clbGenero = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.formSkin1 = new FlatUI.FormSkin();
            this.pic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.formSkin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CalendarFont = new System.Drawing.Font("Segoe UI", 8F);
            this.dtpNascimento.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dtpNascimento.Location = new System.Drawing.Point(15, 165);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(161, 22);
            this.dtpNascimento.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 19;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblNascimento.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNascimento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNascimento.Location = new System.Drawing.Point(12, 148);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(97, 13);
            this.lblNascimento.TabIndex = 22;
            this.lblNascimento.Text = "Inicio da Carreira:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(12, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 13);
            this.lblNome.TabIndex = 23;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 110);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(161, 29);
            this.txtNome.TabIndex = 18;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(15, 370);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(162, 32);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvArtista
            // 
            this.dgvArtista.AllowUserToAddRows = false;
            this.dgvArtista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtista.Location = new System.Drawing.Point(191, 110);
            this.dgvArtista.MultiSelect = false;
            this.dgvArtista.Name = "dgvArtista";
            this.dgvArtista.ReadOnly = true;
            this.dgvArtista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtista.Size = new System.Drawing.Size(336, 259);
            this.dgvArtista.TabIndex = 27;
            this.dgvArtista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtista_CellDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(14, 411);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(162, 33);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cmbCarreira
            // 
            this.cmbCarreira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarreira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCarreira.FormattingEnabled = true;
            this.cmbCarreira.Location = new System.Drawing.Point(15, 218);
            this.cmbCarreira.Name = "cmbCarreira";
            this.cmbCarreira.Size = new System.Drawing.Size(160, 29);
            this.cmbCarreira.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(11, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Carreira Musical:";
            // 
            // clbGenero
            // 
            this.clbGenero.BackColor = System.Drawing.Color.White;
            this.clbGenero.FormattingEnabled = true;
            this.clbGenero.Location = new System.Drawing.Point(10, 18);
            this.clbGenero.Name = "clbGenero";
            this.clbGenero.Size = new System.Drawing.Size(139, 72);
            this.clbGenero.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.clbGenero);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 98);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gênero Musical";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(300, 63);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(206, 29);
            this.txtPesquisa.TabIndex = 34;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(386, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 35);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(247, 387);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(101, 35);
            this.btnConfirmar.TabIndex = 49;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.Transparent;
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCarregar.ForeColor = System.Drawing.Color.White;
            this.btnCarregar.Location = new System.Drawing.Point(619, 387);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(101, 35);
            this.btnCarregar.TabIndex = 52;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.btnCarregar);
            this.formSkin1.Controls.Add(this.dgvArtista);
            this.formSkin1.Controls.Add(this.pic);
            this.formSkin1.Controls.Add(this.txtNome);
            this.formSkin1.Controls.Add(this.btnCancelar);
            this.formSkin1.Controls.Add(this.lblNome);
            this.formSkin1.Controls.Add(this.btnConfirmar);
            this.formSkin1.Controls.Add(this.lblNascimento);
            this.formSkin1.Controls.Add(this.pictureBox2);
            this.formSkin1.Controls.Add(this.label5);
            this.formSkin1.Controls.Add(this.txtPesquisa);
            this.formSkin1.Controls.Add(this.dtpNascimento);
            this.formSkin1.Controls.Add(this.groupBox1);
            this.formSkin1.Controls.Add(this.btnCadastrar);
            this.formSkin1.Controls.Add(this.cmbCarreira);
            this.formSkin1.Controls.Add(this.btnExcluir);
            this.formSkin1.Controls.Add(this.label1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(774, 455);
            this.formSkin1.TabIndex = 54;
            this.formSkin1.Text = "Artista";
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.Location = new System.Drawing.Point(583, 110);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(168, 258);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 51;
            this.pic.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(507, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // frmArtista
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 455);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArtista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Artista";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmArtista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvArtista;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cmbCarreira;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbGenero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FlatUI.FormSkin formSkin1;
    }
}