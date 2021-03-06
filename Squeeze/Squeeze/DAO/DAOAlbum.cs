﻿using MySql.Data.MySqlClient;
using Squeeze.DAO;
using Squeeze.Modelo;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Squeeze
{
    internal class DAOAlbum
    {

        private MySqlConnection con;
        private string comando;
        private MySqlDataReader cursor;
        private List<Album> lista = new List<Album>();
        private List<Artista> lista2 = new List<Artista>();
        private Conexao conex = new Conexao();
        private Artista art = new Artista();
        private Album al = new Album();

        public DAOAlbum()
        {
            con = conex.obterConexao();
        }
        
        public void salvar(Album a)
        {
            con = conex.obterConexao();

            comando = "insert into album (nome, estudio, dtlancamento) values (@nome,@est,@dt)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@nome", a.Nome);
            comandoSQL.Parameters.AddWithValue("@est", a.Estudio);
            comandoSQL.Parameters.AddWithValue("@dt", a.Dt);


            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();

            con.Close();
        }

        public void excluirAlbum(Album a)
        {
            con = conex.obterConexao();

            comando = "delete from album where id = '" + a.IdAlbum + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public void excluirAlbumArtista(Album a)
        {
            con = conex.obterConexao();

            comando = "delete from albumartista where idalbum = '" + a.IdAlbum + "';";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }


        public void salvarAlbumArtista(Artista ar, Album al)
        {
            con = conex.obterConexao();


            comando = "insert into albumartista (idartista, idalbum) values (@idar,@idal)";
            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Parameters.AddWithValue("@idar", ar.Id);
            comandoSQL.Parameters.AddWithValue("@idal", al.IdAlbum);

            //ERRO BEM AQ (FORENG KEY - IDALBUM)

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public Album procurar(Album al)
        {
            con = conex.obterConexao();

            comando = "select * from album where nome = '" + al.Nome + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                al = new Album(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetString("estudio"), cursor.GetString("dtlancamento"));
            }
            con.Close();

            return al;
        }

        public Album procurarId(int id)
        {
            con = conex.obterConexao();

            comando = "select * from album where id = '" + id + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                al = new Album(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetString("estudio"), cursor.GetString("dtlancamento"));
            }
            con.Close();

            return al;
        }

        public List<Album> ListarDados(Artista art)
        {
            con = conex.obterConexao();

            //cria um novo objeto de comandos para serem executados no SQL, usando o comando SQL digitado e a conexão com o banco de dados
            comando = "select * from albumartista where idartista = '" + art.Id + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                Album cat = new Album(cursor.GetInt32("idartista"), cursor.GetInt32("idalbum"));
                lista.Add(cat);
            }
            con.Close();

            return lista;
        }

        public List<Album> ListarDados(Album album)
        {
            con = conex.obterConexao();

            //cria um novo objeto de comandos para serem executados no SQL, usando o comando SQL digitado e a conexão com o banco de dados
            comando = "select * from album where id = '" + album.IdAlbum + "';";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();
            
            while (cursor.Read())
            {
                Album cat = new Album(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetString("estudio"), cursor.GetString("dtlancamento"));
                lista.Add(cat);
            }
            con.Close();

            return lista;
        }

        public void atualizarAlbum(int anterior, string album, string estudio, string lancamento)
        {
            con = conex.obterConexao();

            comando = "update album set nome = '" + album + "', estudio = '" + estudio + "', dtlancamento = '" + lancamento + "' where id = '" + anterior + "' ;";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            comandoSQL.Prepare();
            comandoSQL.ExecuteNonQuery();
            con.Close();
        }

        public List<Album> ListarDados()
        {
            con = conex.obterConexao();
            
            comando = "select * from album;";

            MySqlCommand comandoSQL = new MySqlCommand(comando, con);

            cursor = comandoSQL.ExecuteReader();

            while (cursor.Read())
            {
                Album cat = new Album(cursor.GetInt32("id"), cursor.GetString("nome"), cursor.GetString("estudio"), cursor.GetString("dtlancamento"));
                lista.Add(cat);
            }
            con.Close();

            return lista;
        }


    }
}