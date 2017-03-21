using Squeeze.DAO;
using Squeeze.Modelo;
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
    public partial class frmAlbum : Form
    {
        public frmAlbum()
        {
            InitializeComponent();
            DAOAlbum dal = new DAOAlbum();
            dgvAlbum.DataSource = dal.ListarDados();


            DAOArtista da = new DAOArtista();
            List<Artista> listaG = da.ListarDados();
            for (int x = 0; x < listaG.Count; x++)
            {

                cmbArtista.Items.Insert(x, listaG[x].Nome);

            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string artista;
            string album;
            string estudio;
            string dtLancamento;

            album = txtAlbum.Text;
            estudio = txtEstudio.Text;
            dtLancamento = dtmLancamento.Text;
            artista = cmbArtista.Text;

            ///SALVA O ALBUM BEM AQ
            Album al = new Album(album, estudio, dtLancamento);
            DAOAlbum d = new DAOAlbum();
            d.salvar(al);


            Artista art = new Artista(artista);
            DAOArtista da = new DAOArtista();

            d.salvarAlbumArtista(da.procurar(art), d.procurar(al));


            limpar();
        }

        public void limpar()
        {
            txtAlbum.Text = ("");
            txtEstudio.Text = ("");
            dtmLancamento.Text = ("");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAOAlbum da = new DAOAlbum();
            dgvAlbum.DataSource = da.ListarDados();
        }
    }
}
 