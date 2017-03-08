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


        public DAOGenero()
        {
            con = conex.obterConexao();
        }

        public List<Genero> ListarDados()
        {
            //cria um novo objeto de comandos para serem executados no SQL, usando o comando SQL digitado e a conexão com o banco de dados
            comando = "Select * from generos";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                Genero gen = new Genero(cursor.GetInt32("idGeneros"), cursor.GetString("nomeGeneros"));
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

    }
}
