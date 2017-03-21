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
    public partial class frmGenero : Form
    {
        public frmGenero()
        {
            InitializeComponent();

            DAOGenero dg = new DAOGenero();
            dgvGenero.DataSource = dg.ListarDados();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeG;

            nomeG = txtNome.Text;
            if (nomeG.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
                limpar();
            }
            else
            {
                Genero g = new Genero(nomeG);
                DAOGenero d = new DAOGenero();
                d.salvar(g);
                limpar();
            }
        }

        public void limpar()
        {
            txtNome.Text = ("");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DAOGenero dg = new DAOGenero();
            dgvGenero.DataSource = dg.ListarDados();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Visible = true;
        }
    }
    }