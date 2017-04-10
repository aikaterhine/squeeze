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
        private WaveChannel32 inputStream;
        private OpenFileDialog openFileDialog = new OpenFileDialog();


        private DAOAlbum daoalbum = new DAOAlbum();
        private DAOUsuario daousuario = new DAOUsuario();
        private DAOGenero daogenero = new DAOGenero();

        public Squeeze(string nomeusuario)
        {
            InitializeComponent();

            this.nome = nomeusuario;

            List<Album> listaAlbum = daoalbum.ListarDados();
            for (int x = 0; x < listaAlbum.Count; x++)
            { cmbAlbum.Items.Insert(x, listaAlbum[x].Nome); }

            DAOArtista daoartista = new DAOArtista();
            List<Artista> listaArtista = daoartista.ListarDados();
            for (int x = 0; x < listaArtista.Count; x++)
            { cmbArtistas.Items.Insert(x, listaArtista[x].Nome); }

            cmbUsuario.Items.Add(nome);
            cmbUsuario.Items.Add("Excluir Conta");
            cmbUsuario.Items.Add("Sair");

            btnPlay.Enabled = false;
            btnStop.Enabled = false;
            btnConfirmarPerfil.Hide();

            artistasGeral();
            artistasAscencao();
            artistasRecomendacao();
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
        
        private WaveStream CreateInputStream(string fileName)
        {

            if (fileName.EndsWith(".mp3"))
            {
                WaveStream mp3Reader = new Mp3FileReader(fileName);
                inputStream = new WaveChannel32(mp3Reader);
            }
            else
            {
                flatStatusBar1.Text = "Formato inválido.";
            }
            volumeStream = inputStream;
            return volumeStream;
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

        private void artistasAscencao()
        {
            DAOArtista daoartista = new DAOArtista();
            List<Artista> listaAscencao = daoartista.artistaAscencao();
            List<Artista> listaAscencaoNome = new List<Artista>();
            for (int x = 0; x < listaAscencao.Count; x++)
            {
                listaAscencaoNome.Add(daoartista.procurarId(listaAscencao[x].Id));
            }

            var Pic = new Button();
            var Lab = new Label();

            for (int i = 1; i <= listaAscencaoNome.Count; i++)
            {
                Pic = new Button();
                Pic.Name = "Picture" + i;
                Pic.Text = listaAscencaoNome[i - 1].Nome;
                Pic.BackColor = Color.BlueViolet;
                Pic.Size = new System.Drawing.Size(166, 300);
                Pic.Location = new System.Drawing.Point(i * 120, 50);
                this.panelAscencao.Controls.Add(Pic);
            }
        }

        private void artistasRecomendacao()
        {
            List<Genero> listaGeneros = new List<Genero>();
            List<Genero> listaGeneroArtista = new List<Genero>();
            List<Artista> listaRecomendacoes = new List<Artista>();
            DAOUsuario daousuario = new DAOUsuario();
            DAOArtista daoartista = new DAOArtista();
            var Pic = new Button();
            var Lab = new Label();

            Usuario usuarioNome = new Usuario(nome);

            Usuario usuario = daousuario.procurar(usuarioNome);

            List<Usuario> listaPreferencias = daousuario.preferencias(usuario);

            for (int i = 0; i < listaPreferencias.Count; i++)
            {
                DAOGenero daogenero = new DAOGenero();

                listaGeneros.Add(daogenero.procurar(listaPreferencias[i].Gen));
            }

            for (int i = 0; i < listaGeneros.Count; i++)
            {
                listaGeneroArtista = daogenero.recomendacoes(listaGeneros[i]);
            }

            for (int i = 0; i < listaGeneroArtista.Count; i++)
            {
                listaRecomendacoes = daoartista.ListarDados(listaGeneroArtista[i].IdArtista);
            }

            for (int i = 1; i <= listaRecomendacoes.Count; i++)
            {
                Pic = new Button();
                Pic.Name = "Picture" + i;
                Pic.Text = listaRecomendacoes[i - 1].Nome;
                Pic.BackColor = Color.BlueViolet;
                Pic.Size = new System.Drawing.Size(166, 150);
                Pic.Location = new System.Drawing.Point(i * 120, 50);
                panelRecomendacao.Controls.Add(Pic);
            }
        }

        private void cmbArtistas_SelectedValueChanged(object sender, EventArgs e)
        {

            panelAlbuns.Controls.Clear();

            DAOArtista daoartista = new DAOArtista();
            Artista artNome = new Artista(cmbArtistas.Text);

            Artista artista = daoartista.procurar(artNome);

            DAOAlbum daoalbum = new DAOAlbum();
            List<Album> listaAlbumArtista = daoalbum.ListarDados(artista);

            List<Album> listaAlbum = new List<Album>();
            for (int x = 0; x < listaAlbumArtista.Count; x++)
            {
                listaAlbum.Add(daoalbum.procurarId(listaAlbumArtista[x].IdAlbum));
            }

            var PicAlbum = new Button();

            for (int i = 1; i <= listaAlbum.Count; i++)
            {
                PicAlbum = new Button();
                PicAlbum.Name = listaAlbum[i - 1].Nome;
                PicAlbum.Image = new Bitmap(Properties.Resources.album, 80, 80);
                PicAlbum.Click += new EventHandler(btnAlbum_click);
                PicAlbum.Size = new System.Drawing.Size(100, 130);
                PicAlbum.Location = new System.Drawing.Point(i * 100, 100);
                this.panelAlbuns.Controls.Add(PicAlbum);
            }
        }

        private void btnAlbum_click(object sender, EventArgs e)
        {
            panelInfoAlbum.Controls.Clear();

            DAOAlbum daoalbum = new DAOAlbum();

            var Label = new Label();
            var Label2 = new Label();

            var check = (dynamic)sender;
            string btnAlbum = check.Name;

            Album albNome = new Album(btnAlbum);
            Album album = daoalbum.procurar(albNome);

            Label = new Label();
            Label.Name = btnAlbum + "1";
            Label.Text = "Nome: " + album.Nome;
            Label.ForeColor = Color.White;
            Label.Size = new System.Drawing.Size(200, 80);
            Label.Location = new System.Drawing.Point(0, 0);
            this.panelInfoAlbum.Controls.Add(Label);

            Label = new Label();
            Label.Name = btnAlbum + "2";
            Label.Text = "Estudio: " + album.Estudio;
            Label.ForeColor = Color.White;
            Label.Size = new System.Drawing.Size(200, 80);
            Label.Location = new System.Drawing.Point(0, 80);
            this.panelInfoAlbum.Controls.Add(Label);
            
            Label = new Label();
            Label.Name = btnAlbum + "3";
            Label.Text = "Lançamento: " + album.Dt;
            Label.ForeColor = Color.White;
            Label.Size = new System.Drawing.Size(200, 80);
            Label.Location = new System.Drawing.Point(0, 160);
            this.panelInfoAlbum.Controls.Add(Label);

        }

        private void cmbAlbum_SelectedValueChanged(object sender, EventArgs e)
        {
            panelFaixa.Controls.Clear();

            Album albNome = new Album(cmbAlbum.Text);
            Album album = daoalbum.procurar(albNome);

            DAOFaixa daofaixa = new DAOFaixa();
            List<Faixa> listaFaixa = daofaixa.ListarDados(album);

            var Pic = new Button();

            for (int i = 1; i <= listaFaixa.Count; i++)
            {
                Pic = new Button();
                Pic.Name = listaFaixa[i - 1].Nome;
                Pic.Click += new EventHandler(btnFaixa_click);
                Pic.Image = new Bitmap(Properties.Resources.Mp3_Player_icon, 80, 80);
                Pic.Size = new System.Drawing.Size(100, 130);
                Pic.Location = new System.Drawing.Point(i * 100, 100);
                this.panelFaixa.Controls.Add(Pic);
            }
        }

        private void btnFaixa_click(object sender, EventArgs e)
        {
            panelInfoFaixa.Controls.Clear();

            DAOFaixa daofaixa = new DAOFaixa();

            var Label = new Label();

            var check = (dynamic)sender;
            string btnFaixa = check.Name;

            Faixa faixaNome = new Faixa(btnFaixa);
            Faixa faixa = daofaixa.procurar(faixaNome);
            
            Label = new Label();
            Label.Name = btnFaixa + "1";
            Label.Text = "Nome: " + faixa.Nome;
            Label.ForeColor = Color.White;
            Label.Size = new System.Drawing.Size(200, 50);
            Label.Location = new System.Drawing.Point(0, 0);
            this.panelInfoFaixa.Controls.Add(Label);

            Label = new Label();
            Label.Name = btnFaixa + "2";
            Label.Text = "Duração: " + faixa.Duracao;
            Label.ForeColor = Color.White;
            Label.Size = new System.Drawing.Size(200, 50);
            Label.Location = new System.Drawing.Point(0, 50);
            this.panelInfoFaixa.Controls.Add(Label);
        }

        private void artistasGeral()
        {
            DAOArtista daoartista = new DAOArtista();
            List<Artista> listaArtistas = daoartista.ListarDados();
            var PicB = new Button();
            var panelDetalhes = new Panel();
            for (int i = 1; i <= listaArtistas.Count; i++)
            {
                PicB = new Button();
                PicB.Name = listaArtistas[i - 1].Nome;
                PicB.Image = new Bitmap(Properties.Resources.artista, 80, 80);
                PicB.Click += new EventHandler(btnArtista_click);
                PicB.Size = new System.Drawing.Size(100, 130);
                PicB.Location = new System.Drawing.Point(i * 100, 100);
                this.panelArtista.Controls.Add(PicB);
            }
        }

        private void btnArtista_click(object sender, EventArgs e)
        {
            panelInfo.Controls.Clear();

            DAOArtista daoartista = new DAOArtista();
            
            var Check = new FlatUI.FlatCheckBox();
            var Label = new Label();
            var Label2 = new Label();

            var check = (dynamic)sender;
            string btnArtista = check.Name;

            Artista artNome = new Artista(btnArtista);
            Artista artista = daoartista.procurar(artNome);
            Genero generoArt = daogenero.generoArtista(artista);
            Genero genero = daogenero.procurarId(generoArt.IdGenero);

            Check = new FlatUI.FlatCheckBox();
            Check.Name = btnArtista;
            Check.Text = btnArtista;
            Check.Click += new EventHandler(checkbox_Checked);
            Check.Size = new System.Drawing.Size(100, 20);
            Check.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Controls.Add(Check);

            Label = new Label();
            Label.Name = btnArtista + "1";
            Label.Text = "Nome: " + artNome.Nome;
            Label.ForeColor = Color.White;
            Label.Size = new System.Drawing.Size(200, 50);
            Label.Location = new System.Drawing.Point(0, 30);
            this.panelInfo.Controls.Add(Label);

            Label = new Label();
            Label.Name = btnArtista + "2";
            Label.Text = "Inicio de Carreira: " + artista.Dt;
            Label.ForeColor = Color.White;
            Label.Size = new System.Drawing.Size(200, 50);
            Label.Location = new System.Drawing.Point(0, 100);
            this.panelInfo.Controls.Add(Label);

            Label = new Label();
            Label.Name = btnArtista + "3";
            Label.Text = "Gênero Musical: " + genero.NomeGen;
            Label.ForeColor = Color.White;
            Label.Size = new System.Drawing.Size(200, 50);
            Label.Location = new System.Drawing.Point(0, 170);
            this.panelInfo.Controls.Add(Label);

        }

        private void checkbox_Checked(object sender, EventArgs e)
        {
            var check = (dynamic)sender;

            Artista artNome = new Artista(check.Text);

            DAOArtista daoartista = new DAOArtista();
            Artista art = daoartista.procurar(artNome);

            MessageBox.Show("Id artista: " + art.Id);


            Usuario usuNome = new Usuario(nome);
            Usuario usu = daousuario.procurar(usuNome);

            MessageBox.Show("Id usuario: " + usu.Idusuario);
            

            if (daoartista.verificarFavorito(usu, art) == false)
            {
                daoartista.favoritarArtista(art, usu);
            }
            else {
                daoartista.desfavoritarArtista(art);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            waveOutDevice.Init(mainOutputStream);
            waveOutDevice.Play();
            flatStatusBar1.Text = openFileDialog.FileName;

            btnStop.Enabled = true;
            btnPlay.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            flatStatusBar1.Text = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    file = openFileDialog.FileName;
                    mainOutputStream = CreateInputStream(openFileDialog.FileName);
                }
            }

            btnPlay.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            waveOutDevice.Stop();
            flatStatusBar1.Text = "";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            Usuario usuario = new Usuario(nome, email, senha);
            DAOUsuario daousuario = new DAOUsuario();

            Usuario usuarioAntigoNome = new Usuario(nome);
            Usuario usuarioAntigo = daousuario.procurar(usuarioAntigoNome);

            bool validacao = daousuario.editarPerfil(usuario);

            if (nome.Equals("") || email.Equals("") || senha.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                if (validacao)
                {
                    alertaEmail.Show();
                }
                else
                {
                    daousuario.atualizarUsuario(usuario, usuarioAntigo);
                }
            }

            btnConfirmarPerfil.Hide();
            btnEditarPerfil.Show();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            btnConfirmarPerfil.Show();
            btnEditarPerfil.Hide();

            DAOUsuario daousuario = new DAOUsuario();
            Usuario usuNome = new Usuario(nome);

            Usuario usuario = daousuario.procurar(usuNome);

            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtSenha.Text = usuario.Senha;

        }
    }
}
