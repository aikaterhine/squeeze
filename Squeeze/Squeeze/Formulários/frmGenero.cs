using MySql.Data.MySqlClient;
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
                DAOGenero dg = new DAOGenero();
                Genero g = new Genero(nomeG);
                dg.salvar(g);
                limpar();

                dgvGenero.DataSource = dg.ListarDados();
            }
        }

        public void limpar()
        {
            txtNome.Text = ("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvGenero.CurrentRow.Cells[1].Value);
            DAOGenero dg = new DAOGenero();
            Genero g = new Genero(id);
            try
            {

                dg.excluirGenero(g);
            }
            catch (MySqlException)
            {
                DialogResult confirm = MessageBox.Show("Há referências em outras tabelas. Prosseguir com a operação resultará"
                    + " em perda de dados. Deseja continuar?", "Erro ao excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    dg.excluirGeneroArtista(g);
                    dg.excluirGenero(g);
                }
            }
            
            dgvGenero.DataSource = dg.ListarDados();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Visible = true;
        }

        private void frmGenero_Load(object sender, EventArgs e)
        {

        }
    }
    }