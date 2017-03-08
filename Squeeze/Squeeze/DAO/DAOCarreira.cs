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


        public DAOCarreira()
        {
            con = conex.obterConexao();
        }

        public void salvar(Carreira c)
        {
            comando = "insert into carreiramusical (nomeCarreira) values (@nome)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", c.Nome);
            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public List<Carreira> ListarDados()
        {
            //abre a conexão
            con.Open();

            //cria um novo objeto de comandos para serem executados no SQL, usando o comando SQL digitado e a conexão com o banco de dados
            comando = "Select * from carreiramusical";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                Carreira cat = new Carreira(cursor.GetInt32("idCarreira"), cursor.GetString("nomeCarreira"));
                lista.Add(cat);
            }

            return lista;
        }
    }
}