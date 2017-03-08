using Squeeze.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squeeze
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();

            frm.ShowDialog();

        }

        private void artistaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmArtista frm = new frmArtista();

            frm.MdiParent = this;

            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();

            frm.MdiParent = this;

            frm.Show();
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlbum frm = new frmAlbum();

            frm.MdiParent = this;

            frm.Show();
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenero frm = new frmGenero();

            frm.MdiParent = this;

            frm.Show();
        }

        private void carreiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreira frm = new frmCarreira();

            frm.MdiParent = this;

            frm.Show();
        }

        private void telaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();

            frm.MdiParent = this;

            frm.Show();
        }
    }
}
