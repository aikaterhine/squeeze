using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeeze.DAO
{
    class DAOFaixas
    {
        private MySqlConnection con;
        private string comando;
        private MySqlDataReader cursor;
        private List<Faixa> lista = new List<Faixa>();
        private Conexao conex = new Conexao();


        public DAOFaixas()
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

        public List<Faixa> ListarDados(Album al)
        {

            //cria um novo objeto de comandos para serem executados no SQL, usando o comando SQL digitado e a conexão com o banco de dados
            comando = "select * from faixa where idalbum = '" + al.Id+ "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                Faixa f = new Faixa(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetString("duracao"), cursor.GetString("idalbum"));
                lista.Add(f);
            }

            return lista;
        }
    }
}