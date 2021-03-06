﻿using MySql.Data.MySqlClient;
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

        DAOArtista da = new DAOArtista();
        DAOCarreira dc = new DAOCarreira();

        private int anterior;

        public frmCarreira()
        {
            InitializeComponent();

            btnConfirmar.Hide();
            btnCancelar.Hide();

            DAOCarreira dc = new DAOCarreira();
            dgvCarreira.DataSource = dc.ListarDados();
            dgvCarreira.Rows[0].Selected = true;

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
                DAOCarreira dc = new DAOCarreira();
                Carreira g = new Carreira(nomeC);
                dc.salvar(g);
                limpar();
                dgvCarreira.DataSource = dc.ListarDados();

            }
        }

        public void limpar()
        {
            txtCarreira.Text = ("");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCarreira.CurrentRow.Cells[0].Value);
            DAOCarreira dc = new DAOCarreira();
            Carreira c = new Carreira(id);
            try
            {
                dc.excluirCarreira(c);
            }
            catch (MySqlException)
            {
                DCarreira d = new DCarreira(id);
                d.Show();
            }

            DAOCarreira dc1 = new DAOCarreira();
            dgvCarreira.DataSource = dc1.ListarDados();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome = txtCarreira.Text;

            if (nome.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
            }

            else
            {
                dc.atualizarCarreira(anterior, nome);

                limpar();
                btnCancelar.Hide();
                btnConfirmar.Hide();
                btnCadastrar.Show();
                btnExcluir.Show();

                dgvCarreira.DataSource = dc.ListarDados();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            btnCancelar.Hide();
            btnConfirmar.Hide();
            btnCadastrar.Show();
            btnExcluir.Show();
        }

        private void dgvCarreira_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Hide();
            btnExcluir.Hide();
            btnConfirmar.Show();
            btnCancelar.Show();

            anterior = Convert.ToInt32(dgvCarreira.Rows[e.RowIndex].Cells[1].Value);

            Carreira c = dc.procurarId(anterior);

            txtCarreira.Text = c.Nome;
        }
    }
}
