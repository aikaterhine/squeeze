﻿using MySql.Data.MySqlClient;
using Squeeze.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squeeze.DAO
{
    class DAOGenero
    {
        private MySqlConnection con;
        private string comando;
        private MySqlDataReader cursor;
        private List<Genero> lista = new List<Genero>();
        private Conexao conex = new Conexao();
        private int id;
        private Genero cat;


        public DAOGenero()
        {
            con = conex.obterConexao();
        }

        public List<Genero> ListarDados()
        {
            con = conex.obterConexao();

            //cria um novo objeto de comandos para serem executados no SQL, usando o comando SQL digitado e a conexão com o banco de dados
            comando = "Select * from tipogenero";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                Genero gen = new Genero(cursor.GetInt32("id"), cursor.GetString("nome"));
                lista.Add(gen);
            }

            return lista;
        }

        public void salvar(Genero g)
        {
            con.Open();
            comando = "insert into generos (nomeGeneros) values (@nome)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", g.NomeGen);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }


        public Genero procurar(string g) {
            con = conex.obterConexao();

            comando = "select * from tipogenero where nome = '" + g + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                cat = new Genero(cursor.GetInt32("id"), cursor.GetString("nome"));
                lista.Add(cat);
            }

            return cat;

        }

    }
}
