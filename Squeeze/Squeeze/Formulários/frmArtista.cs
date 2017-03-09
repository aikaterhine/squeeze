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
        public frmArtista()
        {
            
            InitializeComponent();
            DAOArtista da = new DAOArtista();
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
                int idc = dc.validar(car);

                Artista a = new Artista(nome, idc, dt);
                DAOArtista d = new DAOArtista();
                d.salvar(a);

                foreach (object item in clbGenero.CheckedItems)
                {                        
                        d.salvarGeneroArtista(d.procurar(a), dg1.procurar(item.ToString()));
                }
                limpar();
            }
        }

        public void limpar()
        {
            txtNome.Text = ("");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Visible = true;
        }
    }
}
