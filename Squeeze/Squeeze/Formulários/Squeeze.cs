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
using System.Resources;
using Squeeze.Properties;

namespace Squeeze.Formulários
{
    public partial class Squeeze : Form
    {
        private string file;
        private string nome;

        private IWavePlayer waveOutDevice;
        private WaveStream mainOutputStream;
        private WaveChannel32 volumeStream;

        private DAOArtista daoartista = new DAOArtista();
        private DAOAlbum daoalbum = new DAOAlbum();
        private DAOUsuario daousuario = new DAOUsuario();
        private DAOGenero daogenero = new DAOGenero();
        private DAOFaixa daofaixa = new DAOFaixa();

        public Squeeze(string nomeusuario)
        {
            InitializeComponent();

            this.nome = nomeusuario;

            List<Album> listaAlbum = daoalbum.ListarDados();
            for (int x = 0; x < listaAlbum.Count; x++)
            { cmbAlbum.Items.Insert(x, listaAlbum[x].Nome); }

            List<Artista> listaArtista = daoartista.ListarDados();
            for (int x = 0; x < listaArtista.Count; x++)
            { cmbArtistas.Items.Insert(x, listaArtista[x].Nome); }

            cmbUsuario.Items.Add(nome);
            cmbUsuario.Items.Add("Excluir Conta");
            cmbUsuario.Items.Add("Sair");

            artistasAscencao();
        }

        private void Squeeze_Load(object sender, EventArgs e)
        {
            waveOutDevice = new WaveOut();
        }

        private void checkFavorito(string art)
        {
            Usuario u = new Usuario(nome);
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

            else
            {
                MessageBox.Show("Não checkado");

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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    file = openFileDialog.FileName;


                    //Diretório do projeto onde o arquivo Resource está  
                    string BASE_PATH = @"C:\Users\CAT-CAR-TUL\Documents\GitHub\squeeze\Squeeze\Squeeze\Resources";

                    FileInfo fileInfo = new FileInfo(Path.Combine(BASE_PATH, @"Resource.jpg"));
                    using (System.Resources.ResXResourceWriter resWriter = new ResXResourceWriter(fileInfo.FullName))
                    {
                        //Inclui arquivo de imagem  
                        System.Drawing.Image img = System.Drawing.Bitmap.FromFile(Path.Combine(BASE_PATH, @"C:\Users\CAT-CAR-TUL\Pictures\jpgteste.jpg"));
                        resWriter.AddResource("jpgteste", img);

                        //Fecha Resource Writer  
                        resWriter.Close();
                    }
                }
            }
        }

        private void flatComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string selecao = cmbUsuario.Text;

            if (selecao.Equals("Excluir Conta"))
            {
                DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir sua conta permanentemente?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Usuario u = new Usuario(nome);
                    Usuario usu = daousuario.procurar(u);

                    daousuario.excluirPreferencias(usu);
                    daousuario.excluirFavoritos(usu);
                    daousuario.excluirUsuario(usu);
                    this.Dispose();
                }
            }

            else
            {
                MessageBox.Show("Deslogado com sucesso");
                this.Dispose();
            }
        }

        private void flatCheckBox1_CheckedChanged(object sender)
        {
            string art = flatCheckBox1.Text;
            if (art.Equals(""))
            {
                MessageBox.Show("Nenhum artista selecionado. Tente novamente.");
            }
            else
            {
                checkFavorito(art);
            }
        }

        private void flatCheckBox2_CheckedChanged(object sender)
        {
            string art = flatCheckBox2.Text;
            if (art.Equals(""))
            {
                MessageBox.Show("Nenhum artista selecionado. Tente novamente.");
            }
            else
            {
                checkFavorito(art);
            }
        }

        private void flatCheckBox3_CheckedChanged(object sender)
        {

            string art = flatCheckBox3.Text;
            if (art.Equals(""))
            {
                MessageBox.Show("Nenhum artista selecionado. Tente novamente.");
            }
            else
            {
                checkFavorito(art);
            }
        }

        private void flatCheckBox4_CheckedChanged(object sender)
        {
            string art = flatCheckBox4.Text;
            if (art.Equals(""))
            {
                MessageBox.Show("Nenhum artista selecionado. Tente novamente.");
            }
            else
            {
                checkFavorito(art);
            }
        }

        private void flatCheckBox5_CheckedChanged(object sender)
        {
            string art = flatCheckBox5.Text;
            if (art.Equals(""))
            {
                MessageBox.Show("Nenhum artista selecionado. Tente novamente.");
            }
            else
            {
                checkFavorito(art);
            }
        }

        private void flatCheckBox6_CheckedChanged(object sender)
        {
            string art = flatCheckBox6.Text;
            if (art.Equals(""))
            {
                MessageBox.Show("Nenhum artista selecionado. Tente novamente.");
            }
            else
            {
                checkFavorito(art);
            }
        }

        private void flatCheckBox7_CheckedChanged(object sender)
        {
            string art = flatCheckBox7.Text;
            if (art.Equals(""))
            {
                MessageBox.Show("Nenhum artista selecionado. Tente novamente.");
            }
            else
            {
                checkFavorito(art);
            }
        }

        private void flatCheckBox8_CheckedChanged(object sender)
        {
            string art = flatCheckBox8.Text;
            if (art.Equals(""))
            {
                MessageBox.Show("Nenhum artista selecionado. Tente novamente.");
            }
            else
            {
                checkFavorito(art);
            }
        }

        private void flatCheckBox9_CheckedChanged(object sender)
        {
            string art = flatCheckBox9.Text;
            if (art.Equals(""))
            {
                MessageBox.Show("Nenhum artista selecionado. Tente novamente.");
            }
            else
            {
                checkFavorito(art);
            }
        }

        private void cmbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album album = new Album(cmbAlbum.Text);
            List<Faixa> listaFaixa = daofaixa.ListarDados(daoalbum.procurar(album));
            var Pic = new Button();

            foreach (Control item in panelFaixa.Controls.OfType<Button>())
            {
                panelFaixa.Controls.Remove(item);
            }
            for (int i = 1; i <= listaFaixa.Count; i++)
            {
                Pic = new Button();
                Pic.Name = "Pic" + i;
                Pic.Text = listaFaixa[i - 1].Nome;
                Pic.BackColor = Color.BlueViolet;
                Pic.Size = new System.Drawing.Size(100, 130);
                Pic.Location = new System.Drawing.Point(i * 100, 100);
                this.panelFaixa.Controls.Add(Pic);
            }
        }

        private void cmbArtistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Artista artista = new Artista(cmbArtistas.Text);
            List<Album> lista = daoalbum.ListarDados(daoartista.procurar(artista));

            for (int x = 1; x < lista.Count; x++)
            {
                Album album = daoalbum.procurarId(lista[x - 1].IdAlbum);

                var Pic = new Button();

                Pic = new Button();
                Pic.Name = "Pict" + x;
                Pic.Text = lista[x - 1].Nome;
                Pic.BackColor = Color.BlueViolet;
                Pic.Size = new System.Drawing.Size(100, 130);
                Pic.Location = new System.Drawing.Point(x * 100, 100);
                this.panelAlbuns.Controls.Add(Pic);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Copy("C:\\Users\\CAT-CAR-TUL\\Pictures\tabela.png", "C:\\Users\\CAT-CAR-TUL\\Documents\\GitHub\\squeeze\\Squeeze\\Squeeze\\Resources\\Artistas\tabela_copia.png", true);
        }

        private void artistasAscencao() {

            List<Artista> listaF = daoartista.artistaAscencao();
            List<Artista> listaA = new List<Artista>();

            for (int x = 0; x < listaF.Count; x++)
            {
                listaA = daoartista.ListarDados(listaF[x].Id);
            }
            var Pic = new Button();
            var Lab = new Label();

            for (int i = 1; i <= listaA.Count; i++)
            {
                Pic = new Button();
                Pic.Name = "Picture" + i;
                Pic.Text = listaA[i - 1].Nome;
                Pic.BackColor = Color.BlueViolet;
                Pic.Size = new System.Drawing.Size(174, 352);
                Pic.Location = new System.Drawing.Point(i * 7, 35);
                this.panelAscencao.Controls.Add(Pic);

                Lab = new Label();
                Lab.Name = "Label" + i;
                Lab.Text = listaA[i - 1].Nome;
                Lab.Size = new System.Drawing.Size(45, 19);
                Lab.Location = new System.Drawing.Point(i * 68, 378);
                this.panelAscencao.Controls.Add(Lab);
            }
        }
    }
}