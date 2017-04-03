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
    public partial class DCarreira : Form
    {

        private int anterior;
        public DCarreira(int ant)
        {
            InitializeComponent();
            this.anterior = ant;

            DAOCarreira dc = new DAOCarreira();
            List<Carreira> listaC = dc.ListarDados();
            for (int x = 0; x < listaC.Count; x++)
            {
                if (listaC[x].Id != anterior)
                {
                    cmbReferencia.Items.Add(listaC[x].Nome);
                }
            }

            this.anterior = ant;
            btnConfirmar.Hide();
        }

        private void DCarreira_Load(object sender, EventArgs e)
        {

        }

        private void btnSim_Click(object sender, EventArgs e)
        {

            btnConfirmar.Show();
            btnSim.Hide();
            btnNao.Hide();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string cmb = cmbReferencia.Text;

            Carreira cAnterior = new Carreira(anterior);

            Carreira cAtual = new Carreira(cmb);
            DAOCarreira dc = new DAOCarreira();
            DAOArtista da = new DAOArtista();

            dc.atualizarCarreiraArtista(anterior, dc.procurar(cAtual));
            dc.excluirCarreira(cAnterior);

            this.Close();
        }
    }
}
