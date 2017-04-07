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

            DAOGenero dg = new DAOGenero();
            List<Genero> listaG = dg.ListarDados();
            for (int x = 0; x < listaG.Count; x++)
            {
                clbPreferencias.Items.Insert(x, listaG[x].NomeGen);
            }
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

            foreach (object item in clbPreferencias.CheckedItems)
            {
                d.preferencias(d.procurar(u), item.ToString());
            }

            Login login = new Login();
            this.Hide();
            login.ShowDialog();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
