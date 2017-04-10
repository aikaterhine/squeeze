namespace Squeeze.Formulários
{
    partial class Form2
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.formSkin1 = new FlatUI.FormSkin();
            this.btnCarreira = new FlatUI.FlatButton();
            this.flatStatusBar1 = new FlatUI.FlatStatusBar();
            this.btnGenero = new FlatUI.FlatButton();
            this.btnAlbum = new FlatUI.FlatButton();
            this.btnArtista = new FlatUI.FlatButton();
            this.flatMini1 = new FlatUI.FlatMini();
            this.btnFaixa = new FlatUI.FlatButton();
            this.flatMax1 = new FlatUI.FlatMax();
            this.flatClose1 = new FlatUI.FlatClose();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.btnCarreira);
            this.formSkin1.Controls.Add(this.flatStatusBar1);
            this.formSkin1.Controls.Add(this.btnGenero);
            this.formSkin1.Controls.Add(this.btnAlbum);
            this.formSkin1.Controls.Add(this.btnArtista);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.btnFaixa);
            this.formSkin1.Controls.Add(this.flatMax1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(338, 484);
            this.formSkin1.TabIndex = 3;
            this.formSkin1.Text = "Squeeze";
            // 
            // btnCarreira
            // 
            this.btnCarreira.BackColor = System.Drawing.Color.Transparent;
            this.btnCarreira.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnCarreira.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarreira.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCarreira.Location = new System.Drawing.Point(60, 346);
            this.btnCarreira.Name = "btnCarreira";
            this.btnCarreira.Rounded = false;
            this.btnCarreira.Size = new System.Drawing.Size(217, 58);
            this.btnCarreira.TabIndex = 8;
            this.btnCarreira.Text = "Carreira";
            this.btnCarreira.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnCarreira.Click += new System.EventHandler(this.btnCarreira_Click);
            // 
            // flatStatusBar1
            // 
            this.flatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatStatusBar1.ForeColor = System.Drawing.Color.White;
            this.flatStatusBar1.Location = new System.Drawing.Point(0, 462);
            this.flatStatusBar1.Name = "flatStatusBar1";
            this.flatStatusBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStatusBar1.ShowTimeDate = false;
            this.flatStatusBar1.Size = new System.Drawing.Size(338, 22);
            this.flatStatusBar1.TabIndex = 9;
            this.flatStatusBar1.TextColor = System.Drawing.Color.White;
            // 
            // btnGenero
            // 
            this.btnGenero.BackColor = System.Drawing.Color.Transparent;
            this.btnGenero.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGenero.Location = new System.Drawing.Point(60, 286);
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Rounded = false;
            this.btnGenero.Size = new System.Drawing.Size(217, 58);
            this.btnGenero.TabIndex = 8;
            this.btnGenero.Text = "Gênero";
            this.btnGenero.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnGenero.Click += new System.EventHandler(this.btnGenero_Click);
            // 
            // btnAlbum
            // 
            this.btnAlbum.BackColor = System.Drawing.Color.Transparent;
            this.btnAlbum.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlbum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAlbum.Location = new System.Drawing.Point(60, 166);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Rounded = false;
            this.btnAlbum.Size = new System.Drawing.Size(217, 58);
            this.btnAlbum.TabIndex = 1;
            this.btnAlbum.Text = "Album";
            this.btnAlbum.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnArtista
            // 
            this.btnArtista.BackColor = System.Drawing.Color.Transparent;
            this.btnArtista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnArtista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtista.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnArtista.Location = new System.Drawing.Point(60, 106);
            this.btnArtista.Name = "btnArtista";
            this.btnArtista.Rounded = false;
            this.btnArtista.Size = new System.Drawing.Size(217, 58);
            this.btnArtista.TabIndex = 8;
            this.btnArtista.Text = "Artista";
            this.btnArtista.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnArtista.Click += new System.EventHandler(this.btnArtista_Click_1);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(259, 0);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 5;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatMini1.Click += new System.EventHandler(this.flatMini1_Click);
            // 
            // btnFaixa
            // 
            this.btnFaixa.BackColor = System.Drawing.Color.Transparent;
            this.btnFaixa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnFaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaixa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFaixa.Location = new System.Drawing.Point(60, 226);
            this.btnFaixa.Name = "btnFaixa";
            this.btnFaixa.Rounded = false;
            this.btnFaixa.Size = new System.Drawing.Size(217, 58);
            this.btnFaixa.TabIndex = 2;
            this.btnFaixa.Text = "Faixa";
            this.btnFaixa.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnFaixa.Click += new System.EventHandler(this.btnFaixa_Click);
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(289, 0);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 4;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatMax1.Click += new System.EventHandler(this.flatMax1_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(319, 0);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 3;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 484);
            this.Controls.Add(this.formSkin1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatButton btnCarreira;
        private FlatUI.FlatStatusBar flatStatusBar1;
        private FlatUI.FlatButton btnGenero;
        private FlatUI.FlatButton btnAlbum;
        private FlatUI.FlatButton btnArtista;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatButton btnFaixa;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatClose flatClose1;
    }
}