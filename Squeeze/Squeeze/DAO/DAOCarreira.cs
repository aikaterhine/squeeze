using MySql.Data.MySqlClient;
using Squeeze.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeeze.DAO
{
    class DAOCarreira
    {
        private MySqlConnection con;
        private string comando;
        private MySqlDataReader cursor;
        private List<Carreira> lista = new List<Carreira>();
        private Conexao conex = new Conexao();
        private Carreira car = new Carreira();

        public DAOCarreira()
        {
            con = conex.obterConexao();
        }

        public void salvar(Carreira c)
        {
            con = conex.obterConexao();

            comando = "insert into tipocarreira (nome) values (@nome)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", c.Nome);
            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public List<Carreira> ListarDados()
        {
            con = conex.obterConexao();

            //cria um novo objeto de comandos para serem executados no SQL, usando o comando SQL digitado e a conexão com o banco de dados
            comando = "Select * from tipocarreira";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                Carreira cat = new Carreira(cursor.GetInt32("id"), cursor.GetString("nome"));
                lista.Add(cat);
            }

            return lista;
        }

        public void atualizarCarreiraArtista(int anterior, Carreira atual)
        {
            con = conex.obterConexao();

            comando = "update carreiraartista set idcarreira = '" + atual.Id + "' where idcarreira = '" + anterior + "' ;";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void excluirCarreira(Carreira c)
        {
            con = conex.obterConexao();

            comando = "delete from tipocarreira where id = '" + c.Id + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void salvarCarreiraArtista(Artista artista, Carreira carreira)
        {
            con = conex.obterConexao();

            comando = "insert into carreiraartista (idartista, idcarreira) values (@ida,@idc)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@ida", artista.Id);
            comandoSQL.Parameters.AddWithValue("@idc", carreira.Id);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void atualizarCarreira(int anterior, string nome)
        {
            con = conex.obterConexao();

            comando = "update tipocarreira set nome = '" + nome + "' where id = '" + anterior + "' ;";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public Carreira procurarId(int anterior)
        {
            con = conex.obterConexao();

            comando = "select * from tipocarreira where id = '" + anterior + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                car = new Carreira(cursor.GetInt32("id"), cursor.GetString("nome"));
            }
            return car;
        }

        public Carreira procurar(Carreira c)
        {
            con = conex.obterConexao();

            comando = "select * from tipocarreira where nome = '" + c.Nome + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read()) {
                car = new Carreira(cursor.GetInt32("id"), cursor.GetString("nome"));
            }
            return car;
        }

        public void excluirCarreiraArtista(Artista art)
        {
            con = conex.obterConexao();

            comando = "delete from carreiraartista where idartista = '" + art.Id + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }
    }
}