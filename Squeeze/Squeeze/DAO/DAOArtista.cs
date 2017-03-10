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
        Conexao conex = new Conexao();
        private Artista art = new Artista();

        public DAOArtista()
        {
            con = conex.obterConexao();
        }

        public void salvar(Artista a)
        {
            comando = "insert into artista (nome, tipocarreira, dtcarreira) values (@nome,@tipo,@dt)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", a.Nome);
            comandoSQL.Parameters.AddWithValue("@tipo", a.Tipoc);
            comandoSQL.Parameters.AddWithValue("@dt", a.Dt);


            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void salvarGeneroArtista(Artista a, Genero g)
        {
            con = conex.obterConexao();


            comando = "insert into generoartista (idartista, idgenero) values (@ida,@idg)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@ida", a.IdArtista);
            comandoSQL.Parameters.AddWithValue("@idg", g.IdGenero);



            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public List<Artista> ListarDados()
        {

            //cria um novo objeto de comandos para serem executados no SQL, usando o comando SQL digitado e a conexão com o banco de dados
            comando = "Select * from artista";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                Artista cat = new Artista(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetInt32("tipocarreira"), cursor.GetString("dtcarreira"));
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
                art = new Artista(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetInt32("tipocarreira"), cursor.GetString("dtcarreira"));
            }

            return art;
        }
    }
}
