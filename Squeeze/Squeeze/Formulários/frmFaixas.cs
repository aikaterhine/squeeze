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
            string nomeart;
            string nomealb;

            nomealb = cmbAlbum.Text;
            faixa = txtFaixa.Text;
            duracao = txtDuracao.Text;
            nomeart = cmbArtistas.Text;

            if (nomealb.Equals("") || nomeart.Equals("") || faixa.Equals("") || duracao.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");

            }

            else
            {

                Album alb = new Album(nomealb);

                DAOAlbum da = new DAOAlbum();
                Album al = da.procurar(alb);


                Faixa f = new Faixa(faixa, duracao, al.IdAlbum);
                DAOFaixa df = new DAOFaixa();
                df.salvar(f);
                limpar();
            }

        }

        private void cmbAlbum_SelectedValueChanged(object sender, EventArgs e)
        {
            string album = cmbAlbum.Text;

            Album al = new Album(album);
            DAOAlbum d = new DAOAlbum();

            DAOFaixa daf = new DAOFaixa();
            dgvFaixas.DataSource = daf.ListarDados(d.procurar(al));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string artista = cmbArtistas.Text;

            DAOArtista daoart = new DAOArtista();
            Artista al = new Artista(artista);
          
            DAOAlbum daoalb = new DAOAlbum();

            Artista al1 = daoart.procurar(al);
            
            List<Album> listaAl = daoalb.ListarDados(al1);

                for (int x = 0; x < listaAl.Count; x++)
            {

               Album alb = daoalb.procurarId(listaAl[x].IdAlbum);

                cmbAlbum.Items.Insert(x, alb.Nome);
            }
        }

        public void limpar() {
            txtFaixa .Text = ("");
            cmbArtistas.Text = ("");
            cmbAlbum.Text = ("");
            txtDuracao.Text = ("");

        }
    }
}