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

        public DAOArtista()
        {
            con = conex.obterConexao();
        }

        public void salvar(Artista a)
        {
            comando = "insert into artistas (nomeArtistas, nascimento, grupoM, carreiraMusical_idCarreira, generoMusical) values (@nome,@nasc,@grup,@car,@gen)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", a.Nome);
            comandoSQL.Parameters.AddWithValue("@nasc", a.Nascimento);
            comandoSQL.Parameters.AddWithValue("@grup", a.Grupo);
            comandoSQL.Parameters.AddWithValue("@car", a.Carreira);
            comandoSQL.Parameters.AddWithValue("@gen", a.Genero);
            

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public List<Artista> ListarDados()
        {

            //cria um novo objeto de comandos para serem executados no SQL, usando o comando SQL digitado e a conexão com o banco de dados
            comando = "Select * from artistas";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                Artista cat = new Artista(cursor.GetInt32("idArtistas"), cursor.GetString("nomeArtistas"), cursor.GetString("nascimento"), cursor.GetString("grupoM"), cursor.GetString("carreiraMusical_idCarreira"), cursor.GetString("generoMusical"));
                lista.Add(cat);
            }

            return lista;
        }
    }
}
