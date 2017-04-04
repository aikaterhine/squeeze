using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeeze.DAO
{
    class DAOFaixa
    {
        private MySqlConnection con;
        private string comando;
        private MySqlDataReader cursor;
        private List<Faixa> lista = new List<Faixa>();
        private Conexao conex = new Conexao();
        private Faixa f;


        public DAOFaixa()
        {
            con = conex.obterConexao();
        }

        public void salvar(Faixa f)
        {
            comando = "insert into faixa (nome, duracao, idalbum) values (@nome,@dur,@alb)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", f.Nome);
            comandoSQL.Parameters.AddWithValue("@dur", f.Duracao);
            comandoSQL.Parameters.AddWithValue("@alb", f.Idalbum);


            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void excluirFaixa(Faixa f)
        {
            con = conex.obterConexao();

            comando = "delete from faixa where id = '" + f.Id + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void excluirFaixa(Album a)
        {
            con = conex.obterConexao();

            comando = "delete from faixa where idalbum = '" + a.IdAlbum + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public List<Faixa> ListarDados(Album al)
        {
            con = conex.obterConexao();

            //cria um novo objeto de comandos para serem executados no SQL, usando o comando SQL digitado e a conexão com o banco de dados
            comando = "select * from faixa where idalbum = '" + al.IdAlbum + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                Faixa f = new Faixa(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetString("duracao"), cursor.GetInt32("idalbum"));
                lista.Add(f);
            }

            return lista;
        }

        public List<Faixa> ListarDados()
        {
            con = conex.obterConexao();

            //cria um novo objeto de comandos para serem executados no SQL, usando o comando SQL digitado e a conexão com o banco de dados
            comando = "select * from faixa;";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                Faixa cat = new Faixa(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetString("duracao"), cursor.GetInt32("idalbum"));
                lista.Add(cat);
            }

            return lista;

        }

        public Faixa procurarId(int anterior)
        {
            con = conex.obterConexao();

            comando = "select * from faixa where id = '" + anterior + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
               f = new Faixa(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetString("duracao"), cursor.GetInt32("idalbum"));
            }
            return f;
        }

        public void atualizarFaixa(int anterior, string faixa, string duracao)
        {
            con = conex.obterConexao();

            comando = "update faixa set nome = '" + faixa + "', duracao = '" + duracao + "' where id = '" + anterior + "' ;";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }
    }
}