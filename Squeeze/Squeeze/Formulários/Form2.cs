using MySql.Data.MySqlClient;
using Squeeze.DAO;
using Squeeze.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squeeze.Formulários
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void btnArtista_Click(object sender, EventArgs e)
        {
            frmArtista frm = new frmArtista();

            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnCarreira_Click(object sender, EventArgs e)
        {
            frmCarreira frm = new frmCarreira();

            frm.Show();
            this.Hide();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            frmGenero frm = new frmGenero();

            frm.Show();
            this.Hide();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            frmAlbum frm = new frmAlbum();

            frm.Show();
            this.Hide();

        }

        private void btnFaixa_Click(object sender, EventArgs e)
        {
            frmFaixas frm = new frmFaixas();

            frm.Show();
            this.Hide();
        }
    }
}