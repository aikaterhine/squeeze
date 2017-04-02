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

namespace Squeeze
{
    public partial class frmArtista : Form
    {
        DAOGenero dg1 = new DAOGenero();
        DAOArtista da = new DAOArtista();

        public frmArtista()
        {
            
            InitializeComponent();
            dgvArtista.DataSource = da.ListarDados();

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

        private void btnListar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvArtista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* AQUI TEM QUE PEGAR A ID DA LINHA SELECIONADA 
             * E MANDAR COMO ARGUMENTO PARA EDITAR ARTISTA, 
             * PARA ATUALIZAR OS CAMPOS
             */            
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
    }
}
