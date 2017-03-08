using MySql.Data.MySqlClient;
using Squeeze.DAO;
using System;
using System.Collections.Generic;

namespace Squeeze
{
    internal class DAOAlbum
    {

        private MySqlConnection con;
        private string comando;
        private MySqlDataReader cursor;
        private List<Album> lista = new List<Album>();
        private Conexao conex = new Conexao();

        public DAOAlbum()
        {
            con = conex.obterConexao();
        }

        public void salvar(Album a)
        {
            comando = "insert into albuns (nomeAlbum, estudio, dtLancamento, dimensoes) values (@nome,@est,@dt, @dim)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", a.Albuns);
            comandoSQL.Parameters.AddWithValue("@est", a.Estudio);
            comandoSQL.Parameters.AddWithValue("@dt", a.Dt);
            comandoSQL.Parameters.AddWithValue("@dim", a.Dimensoes);


            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            conex.fecharConexao();

        }
    }
}