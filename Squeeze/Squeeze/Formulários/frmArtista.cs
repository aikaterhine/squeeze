using Squeeze.DAO;
using Squeeze.Modelo;
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

namespace Squeeze
{
    public partial class frmArtista : Form
    {
        public frmArtista()
        {

            
            InitializeComponent();
            DAOArtista da = new DAOArtista();
            dgvArtista.DataSource = da.ListarDados();

            DAOGenero dg = new DAOGenero();
            List<Genero> listaG = dg.ListarDados();
            for (int x = 0; x < listaG.Count; x++) {
                cmbGenero.Items.Add(listaG[x].NomeGen);
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
            string nas;
            string gen;
            string gr;
            string car;

            nome = txtNome.Text;
            nas = dtpNascimento.Text;
            gen = cmbGenero.Text;
            gr = txtGrupo.Text;
            car = cmbCarreira.Text;

            if (nome.Equals("") || gr.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
                limpar();
            }
            else
            {

                Artista a = new Artista(nome, nas, gr, car, gen);
                DAOArtista d = new DAOArtista();
                d.salvar(a);
                limpar();
            }
        }

        public void limpar()
        {
            txtNome.Text = ("");
            cmbGenero.Text = ("");
            txtGrupo.Text = ("");
            cmbCarreira.Text = ("");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DAOArtista dc = new DAOArtista();
            dgvArtista.DataSource = dc.ListarDados();
        }

        private void dgvArtista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* AQUI TEM QUE PEGAR A ID DA LINHA SELECIONADA 
             * E MANDAR COMO ARGUMENTO PARA EDITAR ARTISTA, 
             * PARA ATUALIZAR OS CAMPOS
             */

            EditarArtista form = new EditarArtista();
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmArtista_Load(object sender, EventArgs e)
        {

        }
    }
}
