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
using System.Net;

namespace Squeeze.Formulários
{
    public partial class Squeeze : Form
    {
        public Squeeze()
        {
            InitializeComponent();
            cmbUsuario.SelectedIndex = 0;
        }

        private void Squeeze_Load(object sender, EventArgs e)
        {
        }

        private void flatCheckBox1_CheckedChanged(object sender)
        {

            string art = flatCheckBox1.Text;
            string usu = cmbUsuario.Text;
            Usuario u = new Usuario(usu);
            DAOUsuario du = new DAOUsuario();

            Artista a = new Artista(art);
            DAOArtista d = new DAOArtista();

            a = d.procurar(a);
            u = du.procurar(u);


            if (d.verificar(a, u) != true)
            {
                MessageBox.Show("Checkado");

                d.favoritarArtista(a, u);
            }

            else {

                MessageBox.Show("Não checkado");

                flatRadioButton1.Checked = false;

                Artista ar = new Artista(art);
                d.desfavoritarArtista(d.procurar(ar)); ;
            }
        }
        

        private void btnDownload_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completo);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressoFeito);
            webClient.DownloadFileAsync(new Uri("https://mega.nz/fm/QMsWQBwS"), @"C:\Users\CAT-CAR-TUL\Music");
        }

        private void ProgressoFeito(object sender, DownloadProgressChangedEventArgs e)
        {
         //   progressBar.Value = e.ProgressPercentage;
        }

        private void Completo(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download efetuado!");
        }

        private void txtArtista_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }
    }
}
