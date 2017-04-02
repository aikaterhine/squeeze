using MySql.Data.MySqlClient;
using Squeeze.Modelo;
using Squeeze.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squeeze.DAO
{
    class DAOArtista
    {
        private MySqlConnection con;
        private string comando;
        private MySqlDataReader cursor;
        private List<Artista> lista = new List<Artista>();
        private Conexao conex = new Conexao();
        private Artista art = new Artista();
        private bool result = false;

        public DAOArtista()
        {
            con = conex.obterConexao();
        }

        public void salvar(Artista a)
        {
            con = conex.obterConexao();

            comando = "insert into artista (nome, dtcarreira) values (@nome,@dt)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", a.Nome);
            comandoSQL.Parameters.AddWithValue("@dt", a.Dt);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void excluirCarreiraArtista(Carreira c)
        {
            con = conex.obterConexao();

            comando = "delete from carreiraartista where idcarreira = '" + c.Id + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void salvarGeneroArtista(Artista a, Genero g)
        {
            con = conex.obterConexao();

            comando = "insert into generoartista (idartista, idgenero) values (@ida,@idg)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@ida", a.Id);
            comandoSQL.Parameters.AddWithValue("@idg", g.IdGenero);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void favoritarArtista(Artista a, Usuario u)
        {
            con = conex.obterConexao();

            comando = "insert into artistafavorito (idusuario, idartista) values (@idu,@ida)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@idu", u.Idusuario);
            comandoSQL.Parameters.AddWithValue("@ida", a.Id);
            
            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void desfavoritarArtista(Artista a)
        {
            con = conex.obterConexao();
            
            comando = "delete from artistafavorito where idartista = '" + a.Id + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@ida", a.Id);
            
            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public bool verificar(Artista a, Usuario u)
        {
            con = conex.obterConexao();

            comando = "select * from artistafavorito where idusuario = '" + u.Idusuario + "' and idartista = '" + a.Id + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();
            result = cursor.HasRows;

            return result;
        }

        public List<Artista> ListarDados()
        {
            con = conex.obterConexao();

            //cria um novo objeto de comandos para serem executados no SQL, usando o comando SQL digitado e a conexão com o banco de dados
            comando = "Select * from artista";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                Artista cat = new Artista(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetString("dtcarreira"));
                lista.Add(cat);
            }

            return lista;
        }

        public Artista procurar(Artista a)
        {
            con = conex.obterConexao();

            comando = "select * from artista where nome = '" + a.Nome + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                art = new Artista(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetString("dtcarreira"));
            }

            return art;
        }

        public List<Artista> pesquisar(string nome) {
            comando = "select * from artista where nome like '" + nome + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                art = new Artista(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetString("dtcarreira"));
                lista.Add(art);
            }

            return lista;

        }
    }
}
