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
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvArtista = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbCarreira = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtista)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(6, 160);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(161, 20);
            this.dtpNascimento.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Gênero Musical:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Grupo Musical:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblNascimento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNascimento.Location = new System.Drawing.Point(3, 144);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(66, 13);
            this.lblNascimento.TabIndex = 22;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(3, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 23;
            this.lblNome.Text = "Nome:";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(6, 269);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(161, 20);
            this.txtGrupo.TabIndex = 16;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 111);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(161, 20);
            this.txtNome.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 24);
            this.button1.TabIndex = 26;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvArtista
            // 
            this.dgvArtista.AllowUserToAddRows = false;
            this.dgvArtista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtista.Location = new System.Drawing.Point(182, 111);
            this.dgvArtista.Name = "dgvArtista";
            this.dgvArtista.ReadOnly = true;
            this.dgvArtista.Size = new System.Drawing.Size(542, 232);
            this.dgvArtista.TabIndex = 27;
            this.dgvArtista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtista_CellDoubleClick);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(482, 365);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(162, 25);
            this.btnListar.TabIndex = 28;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(7, 217);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(160, 21);
            this.cmbGenero.TabIndex = 29;
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbCarreira
            // 
            this.cmbCarreira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarreira.FormattingEnabled = true;
            this.cmbCarreira.Location = new System.Drawing.Point(9, 322);
            this.cmbCarreira.Name = "cmbCarreira";
            this.cmbCarreira.Size = new System.Drawing.Size(160, 21);
            this.cmbCarreira.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(5, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Carreira Musical:";
            // 
            // frmArtista
            // 
            this.BackgroundImage = global::Squeeze.Properties.Resources._32c9dec15f5b9bf92081e8ea7acb2527;
            this.ClientSize = new System.Drawing.Size(739, 402);
            this.Controls.Add(this.cmbCarreira);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvArtista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.txtNome);
            this.Name = "frmArtista";
            this.Text = "Cadastro de Artista";
            this.Load += new System.EventHandler(this.frmArtista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvArtista;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbCarreira;
        private System.Windows.Forms.Label label1;
    }
}