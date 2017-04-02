using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeeze.DAO
{
    class Conexao
    {
        public MySqlConnection con;

        public MySqlConnection obterConexao()
        {

            string strconexao = "server=localhost;userid=root;password=12345;database=squeezebd";
            con = new MySqlConnection(strconexao);
            try
            {
                con.Open();
            }
            catch (MySqlException)
            {
                con = null;
            }

            return con;
        }
        public void fecharConexao()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}