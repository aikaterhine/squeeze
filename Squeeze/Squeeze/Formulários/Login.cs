using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squeeze.Formulários;
using Squeeze.Modelo;
using Squeeze.DAO;

namespace Squeeze
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool logado = false;
        private int perfil;

        private void label1_Click(object sender, EventArgs e)
        {
            CadastroUsuario cad = new CadastroUsuario();
            cad.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            Usuario u = new Usuario(login, senha);
            DAOUsuario d = new DAOUsuario();
            logado = d.validar(u);
            perfil = d.acesso(u);

            if (logado)
            {
               
                MessageBox.Show("Seja bem vindo!");

                switch (perfil) {
                    case 0:
                        Form1 nav = new Form1();
                        nav.ShowDialog();
                        break;
                    case 1:

                        break;
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
