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
        private List<Album> lista = new List<Album>();
        private Conexao conex = new Conexao();


        public DAOFaixas()
        {
            con = conex.obterConexao();
        }

        public void salvar(Faixa f)
        {
            comando = "insert into faixas (nomeF, duracaoF, artistas_idArtistas, albuns_idArtistas) values (@nome,@dur,@art, @alb)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", f.Nome);
            comandoSQL.Parameters.AddWithValue("@dur", f.Duracao);
            comandoSQL.Parameters.AddWithValue("@art", f.Artista_faixa);
            comandoSQL.Parameters.AddWithValue("@alb", f.Album_faixa);


            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }
    }
}