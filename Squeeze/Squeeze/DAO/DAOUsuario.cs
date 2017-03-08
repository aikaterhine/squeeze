using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Squeeze.Modelo;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace Squeeze.DAO
{
    class DAOUsuario
    {
        private MySqlConnection con;
        private string comando;
        private MySqlDataReader cursor;
        private Conexao conex = new Conexao();
        private bool result = false;
        private int perfil;

        public DAOUsuario()
        {
            con = conex.obterConexao();
        }

        public void salvar(Usuario u)
        {
            comando = "insert into usuarios (nomeU, emailU, senhaU) values (@nome,@email,@senha)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", u.Nome);
            comandoSQL.Parameters.AddWithValue("@email", u.Email);
            comandoSQL.Parameters.AddWithValue("@senha", u.Senha);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public bool validar(Usuario u)
        {
            con.Open();
            comando = "select * from usuarios where emailU = '" + u.Email + "' and senhaU = '" + u.Senha + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();
            result = cursor.HasRows;

            return result;
        }

        public int acesso(Usuario u)
        {
            con.Open();
            comando = "select * from usuarios where emailU = '" + u.Email + "' and senhaU = '" + u.Senha + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();
            while (cursor.Read())
            {
                perfil = Convert.ToInt32(cursor["IdCliente"].ToString());
            }

            return perfil;
        }
    }
}