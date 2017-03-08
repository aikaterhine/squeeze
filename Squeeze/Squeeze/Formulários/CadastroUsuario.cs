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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            string nome, email, senha;

            nome = txtNome.Text;
            email = txtEmail.Text;
            senha = txtSenha.Text;


            Usuario u = new Usuario(nome, email, senha, 0);
            DAOUsuario d = new DAOUsuario();
            d.salvar(u);

            Login login = new Login();
            login.ShowDialog();

            this.Hide();
        }

        public void limpar()
        {
            txtNome.Text = ("");
            txtEmail.Text = ("");
            txtSenha.Text = ("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }
    }
}
