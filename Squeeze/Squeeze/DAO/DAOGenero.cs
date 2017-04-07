using MySql.Data.MySqlClient;
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

        public void atualizarGeneroArtista(int anterior, Genero genero)
        {
            con = conex.obterConexao();

            comando = "update generoartista set idgenero = '" + genero.IdGenero + "' where idgenero = '" + anterior + "' ;";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void salvar(Genero g)
        {
            con = conex.obterConexao();

            comando = "insert into tipogenero (nome) values (@nome)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", g.NomeGen);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void excluirGenero(Genero g)
        {
            con = conex.obterConexao();

            comando = "delete from tipogenero where id = '" + g.IdGenero + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public Genero procurarId(int anterior)
        {
            con = conex.obterConexao();

            comando = "select * from tipogenero where id = '" + anterior + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                cat = new Genero(cursor.GetInt32("id"), cursor.GetString("nome"));
                lista.Add(cat);
            }
            return cat;
        }
    

        public void excluirGeneroArtista(Genero g)
        {
            con = conex.obterConexao();

            comando = "delete from generoartista where idgenero = '" + g.IdGenero + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public List<Genero> recomendacoes(Genero gen)
        {
            con = conex.obterConexao();

            comando = "select * from generoartista where idgenero = '" + gen.IdGenero + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                cat = new Genero(cursor.GetInt32("idartista"), cursor.GetInt32("idgenero"));
                lista.Add(cat);
            }
            return lista;
        }

        public void atualizarGenero(int anterior, string nome)
        {
            con = conex.obterConexao();

            comando = "update tipogenero set nome = '" + nome + "' where id = '" + anterior + "' ;";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

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
            }
            return cat;
        }

        public void excluirGeneroArtista(Artista art)
        {
            con = conex.obterConexao();

            comando = "delete from generoartista where idartista = '" + art.Id + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }
    }
}
