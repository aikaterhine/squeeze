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
        private DAOGenero dg = new DAOGenero();
        private int anterior;

        public frmGenero()
        {
            InitializeComponent();

            btnConfirmar.Hide();
            btnCancelar.Hide();


            dgvGenero.DataSource = dg.ListarDados();
            dgvGenero.Rows[0].Selected = true;

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
                DGenero dia = new DGenero(id);
                dia.Show();
            }
            
            dgvGenero.DataSource = dg.ListarDados();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Visible = true;
        }

        private void dgvGenero_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Hide();
            btnExcluir.Hide();
            btnConfirmar.Show();
            btnCancelar.Show();

            anterior = Convert.ToInt32 (dgvGenero.Rows[e.RowIndex].Cells[1].Value);

            Genero g = dg.procurarId(anterior);

            txtNome.Text = g.NomeGen;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            btnCancelar.Hide();
            btnConfirmar.Hide();
            btnCadastrar.Show();
            btnExcluir.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (nome.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
            }

            else
            {
                dg.atualizarGenero(anterior, nome);

                limpar();
                btnCancelar.Hide();
                btnConfirmar.Hide();
                btnCadastrar.Show();
                btnExcluir.Show();

                dgvGenero.DataSource = dg.ListarDados();
            }
        }
    }
    }