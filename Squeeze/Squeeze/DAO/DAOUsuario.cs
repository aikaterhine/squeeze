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
        private List<Usuario> lista = new List<Usuario>();
        private Conexao conex = new Conexao();
        private bool result = false;
        private int perfil;
        private Usuario usuario = new Usuario();


        public DAOUsuario()
        {
            con = conex.obterConexao();
        }

        public void salvar(Usuario u)
        {
            comando = "insert into usuario (nome, email, senha, tipo) values (@nome,@email,@senha,@tipo)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", u.Nome);
            comandoSQL.Parameters.AddWithValue("@email", u.Email);
            comandoSQL.Parameters.AddWithValue("@senha", u.Senha);
            comandoSQL.Parameters.AddWithValue("@tipo", u.Tipo);



            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void preferencias(Usuario usuario, string genero)
        {
            comando = "insert into preferencias (idusuario, genero) values (@id,@genero)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@id", usuario.Idusuario);
            comandoSQL.Parameters.AddWithValue("@genero", genero);
            
            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public bool validar(Usuario u)
        {
            con = conex.obterConexao();

            comando = "select * from usuario where email = '" + u.Email + "' and senha = '" + u.Senha + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();
            result = cursor.HasRows;

            return result;
        }

        public int acesso(Usuario u)
        {
            con = conex.obterConexao();

            comando = "select * from usuario where email = '" + u.Email + "' and senha = '" + u.Senha + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                perfil = Convert.ToInt32(cursor["tipo"].ToString());
            }

            return perfil;
        }

        public Usuario procurar(Usuario u)
        {
            con = conex.obterConexao();

            comando = "select * from usuario where nome = '" + u.Nome + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                usuario = new Usuario(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetString("email"), cursor.GetString("senha"), cursor.GetInt32("tipo"));
            }

            return usuario;
        }

        public List<Usuario> preferencias(Usuario usuario)
        {
            con = conex.obterConexao();

            comando = "select * from preferencias where idusuario = '" + usuario.Idusuario + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                usuario = new Usuario(cursor.GetInt32("idusuario"), cursor.GetString("genero"));
                lista.Add(usuario);
            }
            return lista;
        }

        public void excluirPreferencias(Usuario usu)
        {
            con = conex.obterConexao();

            comando = "delete from preferencias where idusuario = '" + usu.Idusuario+ "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void excluirFavoritos(Usuario usu)
        {
            con = conex.obterConexao();

            comando = "delete from artistafavorito where idusuario = '" + usu.Idusuario + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void excluirUsuario(Usuario usu)
        {
            con = conex.obterConexao();

            comando = "delete from usuario where id = '" + usu.Idusuario + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }
    }
}