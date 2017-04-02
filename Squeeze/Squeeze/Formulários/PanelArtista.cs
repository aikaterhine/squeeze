using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squeeze.DAO;
using Squeeze.Modelo;

namespace Squeeze.Formulários
{
    public partial class PanelArtista : UserControl
    {
        DAOGenero dg1 = new DAOGenero();
        DAOArtista da = new DAOArtista();

        public PanelArtista()
        {
            InitializeComponent();
            dgvArtista.DataSource = da.ListarDados();

            DAOGenero dg = new DAOGenero();
            List<Genero> listaG = dg.ListarDados();
            for (int x = 0; x < listaG.Count; x++)
            {

                clbGenero.Items.Insert(x, listaG[x].NomeGen);

            }

            DAOCarreira dc = new DAOCarreira();
            List<Carreira> listaC = dc.ListarDados();
            for (int x = 0; x < listaC.Count; x++)
            {
                cmbCarreira.Items.Add(listaC[x].Nome);
            }
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            string dt;
            string car;
            List<String> gen = new List<String>();

            nome = txtNome.Text;
            dt = dtpNascimento.Text;
            car = cmbCarreira.Text;

            if (nome.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
                limpar();
            }
            else
            {

                DAOCarreira dc = new DAOCarreira();

                Artista a = new Artista(nome, dt);
                Carreira c = new Carreira(car);
                da.salvar(a);
                dc.salvarCarreiraArtista(da.procurar(a), dc.procurar(c));

                foreach (object item in clbGenero.CheckedItems)
                {
                    da.salvarGeneroArtista(da.procurar(a), dg1.procurar(item.ToString()));
                }
                limpar();

                dgvArtista.DataSource = da.ListarDados();
            }

        }
        public void limpar()
        {
            txtNome.Text = ("");
            cmbCarreira.Text = ("");
        }
    }
}
