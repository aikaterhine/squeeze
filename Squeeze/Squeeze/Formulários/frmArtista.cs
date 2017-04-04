using Squeeze.DAO;
using Squeeze.Modelo;
using Squeeze.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Documents;
using MySql.Data.MySqlClient;

namespace Squeeze
{
    public partial class frmArtista : Form
    {
        DAOGenero dg1 = new DAOGenero();
        DAOArtista da = new DAOArtista();
        DAOFaixa df = new DAOFaixa();
        DAOAlbum d = new DAOAlbum();
        DAOCarreira dc = new DAOCarreira();
        int anterior;

        public frmArtista()
        {
            
            InitializeComponent();
            btnCancelar.Hide();
            btnConfirmar.Hide();

            dgvArtista.DataSource = da.ListarDados();
            dgvArtista.Rows[0].Selected = true;

            DAOGenero dg = new DAOGenero();
            List<Genero> listaG = dg.ListarDados();
            for (int x = 0; x < listaG.Count; x++) {
                
                clbGenero.Items.Insert(x, listaG[x].NomeGen);

            }

            DAOCarreira dc = new DAOCarreira();
            List<Carreira> listaC = dc.ListarDados();
            for (int x = 0; x < listaC.Count; x++)
            {
                cmbCarreira.Items.Add(listaC[x].Nome);
            }
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            string dt;
            string car;
            List<String> gen = new List<String>();

            nome = txtNome.Text;
            dt = dtpNascimento.Text;
            car = cmbCarreira.Text;

            if (nome.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
                limpar();
            }
            else
            {

                DAOCarreira dc = new DAOCarreira();

                Artista a = new Artista(nome, dt);
                Carreira c = new Carreira(car);
                da.salvar(a);
                dc.salvarCarreiraArtista(da.procurar(a), dc.procurar(c));

                foreach (object item in clbGenero.CheckedItems)
                {                        
                        da.salvarGeneroArtista(da.procurar(a), dg1.procurar(item.ToString()));
                }
                limpar();

                dgvArtista.DataSource = da.ListarDados();
            }
        }

        public void limpar()
        {
            txtNome.Text = ("");
            cmbCarreira.Text = ("");
        }

        private void dgvArtista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Hide();
            btnExcluir.Hide();
            btnConfirmar.Show();
            btnCancelar.Show();


            anterior = Convert.ToInt32(dgvArtista.Rows[e.RowIndex].Cells[0].Value);

            Artista a = da.procurarId(anterior);

            txtNome.Text = a.Nome;
            dtpNascimento.Text = a.Dt;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;

            DAOArtista da = new DAOArtista();

            dgvArtista.DataSource = da.pesquisar(pesquisa);
        }

        private void frmArtista_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string dt = dtpNascimento.Text;

            if (nome.Equals("") || dt.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
            }

            else
            {
                da.atualizarArtista(anterior, nome, dt);
                limpar();
                btnCancelar.Hide();
                btnConfirmar.Hide();
                btnCadastrar.Show();
                btnExcluir.Show();
                dgvArtista.DataSource = da.ListarDados();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvArtista.CurrentRow.Cells[0].Value);
            Artista art = new Artista(id);

            try
            {
                da.excluirArtista(art);
            }
            catch (MySqlException)
            {
                DialogResult confirm = MessageBox.Show("Há referências em outras tabelas. Prosseguir com a operação resultará"
                    + "em perda de dados. Deseja continuar?", "Erro ao excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {

                    List<Album> listaA = d.ListarDados(art);
                    
                    for (int x = 0; x < listaA.Count; x++)
                    {
                        Album dal = new Album(listaA[x].IdAlbum);
                        df.excluirFaixa(dal);
                    }
                    for (int x = 0; x < listaA.Count; x++)
                    {
                        Album dal = new Album(listaA[x].IdAlbum);
                        d.excluirAlbumArtista(dal);
                    }
                    for (int x = 0; x < listaA.Count; x++)
                    {
                        Album dal = new Album(listaA[x].IdAlbum);
                        d.excluirAlbum(dal);
                    }

                    dc.excluirCarreiraArtista(art);
                    dg1.excluirGeneroArtista(art);
                    da.desfavoritarArtista(art);
                    da.excluirArtista(art);
                }
            }
            dgvArtista.DataSource = da.ListarDados();
        }
    }
}
