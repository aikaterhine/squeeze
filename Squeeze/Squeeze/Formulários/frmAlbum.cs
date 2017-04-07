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
using MySql.Data.MySqlClient;

namespace Squeeze
{
    public partial class frmAlbum : Form
    {
        DAOAlbum d = new DAOAlbum();
        DAOArtista da = new DAOArtista();
        DAOFaixa df = new DAOFaixa();
        int anterior;


        public frmAlbum()
        {
            InitializeComponent();

            btnConfirmar.Hide();
            btnCancelar.Hide();

            dgvAlbum.DataSource = d.ListarDados();
            dgvAlbum.Rows[0].Selected = true;


            List<Artista> listaG = da.ListarDados();
            for (int x = 0; x < listaG.Count; x++)
            {

                cmbArtista.Items.Insert(x, listaG[x].Id);

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
            Artista art = new Artista(artista);

            d.salvar(al);
            d.salvarAlbumArtista(da.procurar(art), d.procurar(al));
            
            limpar();

            dgvAlbum.DataSource = d.ListarDados();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvAlbum.CurrentRow.Cells[0].Value);
            Album al = new Album(id);

            try
            {
                d.excluirAlbum(al);
            }
            catch (MySqlException)
            {
                DialogResult confirm = MessageBox.Show("Há referências em outras tabelas. Prosseguir com a operação resultará"
                    + "em perda de dados. Deseja continuar?", "Erro ao excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    df.excluirFaixa(al);
                    d.excluirAlbum(al);
                }
            }

            dgvAlbum.DataSource = da.ListarDados();
        }

        private void frmAlbum_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string album = txtAlbum.Text;
            string estudio = txtEstudio.Text;
            string lancamento = dtmLancamento.Text;

            if (album.Equals("") || estudio.Equals("") || lancamento.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
            }

            else
            {
                d.atualizarAlbum(anterior, album, estudio, lancamento);
                limpar();

                btnCancelar.Hide();
                btnConfirmar.Hide();
                btnCadastrar.Show();
                btnExcluir.Show();
                dgvAlbum.DataSource = da.ListarDados();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            btnCancelar.Hide();
            btnConfirmar.Hide();
            btnCadastrar.Show();
            btnExcluir.Show();
        }

        private void dgvAlbum_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Hide();
            btnExcluir.Hide();
            btnConfirmar.Show();
            btnCancelar.Show();


            anterior = Convert.ToInt32(dgvAlbum.Rows[e.RowIndex].Cells[0].Value);

            Album a = d.procurarId(anterior);

            txtAlbum.Text = a.Nome;
            txtEstudio.Text = a.Estudio;
            dtmLancamento.Text = a.Dt;
        }
    }
}
 