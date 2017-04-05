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
using NAudio.Wave;
using System.IO;

namespace Squeeze.Formulários
{
    public partial class Squeeze : Form
    {
        string file;
        IWavePlayer waveOutDevice;
        WaveStream mainOutputStream;
        WaveChannel32 volumeStream;

        public Squeeze()
        {
            InitializeComponent();
            cmbUsuario.SelectedIndex = 0;
        }

        private void Squeeze_Load(object sender, EventArgs e)
        {
            waveOutDevice = new WaveOut();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DAOArtista da = new DAOArtista();
            List<Artista> listaF = da.artistaAscencao();
            List<Artista> listaA;
            for (int x = 0; x < listaF.Count; x++)
            {
                listaA = da.ListarDados(listaF[x].Id);
            }

            MessageBox.Show(listaF[x].Nome);

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    file = openFileDialog.FileName;
                    mainOutputStream = CreateInputStream(openFileDialog.FileName);
                }
            }

            btnPlay.Enabled = true;
            btnPause.Enabled = true;
        }

        private WaveStream CreateInputStream(string fileName)
        {
            WaveChannel32 inputStream;
            if (fileName.EndsWith(".mp3"))
            {
                WaveStream mp3Reader = new Mp3FileReader(fileName);
                inputStream = new WaveChannel32(mp3Reader);
            }
            else
            {
                throw new InvalidOperationException("Unsupported extension");
            }
            volumeStream = inputStream;
            return volumeStream;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            waveOutDevice.Init(mainOutputStream);
            waveOutDevice.Play();

            btnPlay.Enabled = true;

        }
    } 
}
