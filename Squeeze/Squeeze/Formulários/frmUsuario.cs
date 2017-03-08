using Squeeze.DAO;
using Squeeze.Formulários;
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

namespace Squeeze
{
    public partial class frmUsuario : Form
    {
        bool logado = false;
        bool resultado = false;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {

            string nome, email, senha;

            nome = txtNome.Text;
            email = txtEmail.Text;
            senha = txtSenha.Text;


            Usuario u = new Usuario(nome, email, senha);
            DAOUsuario d = new DAOUsuario();
            d.salvar(u);
            limpar();
        }


        public void limpar()
        {
            txtNome.Text = ("");
            txtEmail.Text = ("");
            txtSenha.Text = ("");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenhaLogin.Text;

            Usuario u = new Usuario(login, senha);
            DAOUsuario d = new DAOUsuario();
            resultado = d.validar(u);
            logado = resultado;

            if (resultado)
            {

                MessageBox.Show("Seja bem vindo!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!");
            }

        }

        private void frmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (logado)
            {
                this.Hide();

                Browse frm = new Browse();

                frm.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
