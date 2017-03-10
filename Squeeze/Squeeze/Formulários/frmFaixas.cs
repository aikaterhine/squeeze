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
    public partial class frmFaixas : Form
    {
        public frmFaixas()
        {
            InitializeComponent();

            DAOArtista da = new DAOArtista();
            List<Artista> listaG = da.ListarDados();
            for (int x = 0; x < listaG.Count; x++)
            {

                cmbArtistas.Items.Insert(x, listaG[x].Nome);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string duracao;
            string faixa;

            faixa = txtFaixa.Text;
            duracao = txtDuracao.Text;

            /*  Artista art = new Artista(artista);
              DAOArtista da = new DAOArtista();

              d.salvarAlbumArtista(da.procurar(art), d.procurar(al));*/
        }

        private void cmbAlbum_SelectedValueChanged(object sender, EventArgs e)
        {
            string album = cmbAlbum.Text;

            Album al = new Album(album);
            DAOAlbum d = new DAOAlbum();

            DAOFaixas daf = new DAOFaixas();
            dgvFaixas.DataSource = daf.ListarDados(d.procurar(al));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string artista = cmbArtistas.Text;

            Artista al = new Artista(artista);
            DAOArtista d = new DAOArtista();
            DAOAlbum da = new DAOAlbum();


            // LISTA COM RELAÇÃO DE ARTISTAS E RESPECTIVOS ALBUNS
            List<Album> listaAl = da.ListarDados(d.procurar(al)); /*   LISTA COM ARTISTAS QUE TENHAM O NOME SELECIONADO NA COMBOBOX)*/

            //AQUI NAO TA FUNCIONANDO

            for (int x = 0; x < listaAl.Count; x++)
            {

                Album alb = new Album(listaAl[x].Id);

                List<Album> a = new List<Album>();

                a.Add(da.procurarId(alb));
                    
                cmbAlbum.Items.Insert(x, a[x].Nome);
            }


        }


    }
}