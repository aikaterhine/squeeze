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
    public partial class frmCarreira : Form
    {
        public frmCarreira()
        {
            InitializeComponent();

            DAOCarreira dc = new DAOCarreira();
            dgvCarreira.DataSource = dc.ListarDados();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeC;

            nomeC = txtCarreira.Text;
            if (nomeC.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
                limpar();
            }
            else
            {
                Carreira g = new Carreira(nomeC);
                DAOCarreira d = new DAOCarreira();
                d.salvar(g);
                limpar();
            }
        }

        public void limpar()
        {
            txtCarreira.Text = ("");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DAOCarreira dc = new DAOCarreira();
            dgvCarreira.DataSource = dc.ListarDados();
        }
    }
}
