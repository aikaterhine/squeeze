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
    public partial class DGenero : Form
    {
        private int anterior;
        public DGenero(int ant)
        {
            InitializeComponent();

            InitializeComponent();
            this.anterior = ant;

            DAOGenero dg = new DAOGenero();
            List<Genero> listaG = dg.ListarDados();
            for (int x = 0; x < listaG.Count; x++)
            {
                if (listaG[x].IdGenero != anterior)
                {
                    cmbReferencia.Items.Add(listaG[x].NomeGen);
                }
            }

            this.anterior = ant;
            btnConfirmar.Hide();
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

            Genero gAnterior = new Genero(anterior);
            DAOGenero dg = new DAOGenero();
            DAOArtista da = new DAOArtista();

            dg.atualizarGeneroArtista(anterior, dg.procurar(cmb));
            dg.excluirGenero(gAnterior);

            this.Close();
        }
    }
}
