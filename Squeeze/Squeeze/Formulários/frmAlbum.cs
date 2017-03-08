using Squeeze.DAO;
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
    public partial class frmAlbum : Form
    {
        public frmAlbum()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string album;
            string estudio;
            string dtLancamento;
            string dimensoes;

            album = txtAlbum.Text;
            estudio = txtEstudio.Text;
            dtLancamento = dtmLancamento.Text;
            dimensoes = cmbDimensoes.Text;


            Album al = new Album(album, estudio, dtLancamento, dimensoes);
            DAOAlbum d = new DAOAlbum();
            d.salvar(al);
            limpar();
        }

        public void limpar()
        {
            txtAlbum.Text = ("");
            txtEstudio.Text = ("");
            dtmLancamento.Text = ("");
            cmbDimensoes.Text = ("");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
