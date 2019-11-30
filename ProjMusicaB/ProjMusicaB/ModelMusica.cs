using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ProjMusicaB
{
    class ModelMusica
    {
        MetodosUteis metodos = new MetodosUteis();

        public DataTable listarMusicas()
        {
            MySqlConnection cnx = new MySqlConnection(metodos.conectaDBMySql());

            try
            {
                //cnx.Open();
                MySqlCommand comando = new MySqlCommand("SELECT m.id,m.artista, " +
                    "m.nroFaixa ,m.titulo, m.album, g.descricao as genero FROM tbl_musicas" +
                    " as m LEFT JOIN tbl_genro as g" +
                    " on m.idGenero = g.idGenero order by m.artista,m.nroFaixa", cnx);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                  DataTable dt = new DataTable();
                // adapter.Fill(dt);
                 return dt;
            }
            finally
            {
               // cnx.Close();
            }

        }


        public int addMusica(Musica music)
        {
            MySqlConnection cnx = new MySqlConnection(metodos.conectaDBMySql());
            int count = 0;
            try
            {
                cnx.Open();

                MySqlCommand comando = new MySqlCommand("INSERT INTO tbl_musicas" +
                    "(titulo, artista, idGenero, album, nroFaixa) VALUES (" +
                    "'" + music.getTitulo() + "', '" + music.getArtista() + "', '" +
                     music.getGenero() + "', '" + music.getAlbum() + "', '" +
                     music.getNroFaixa() + "' )", cnx);

                count = comando.ExecuteNonQuery();
                return count;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                cnx.Close();
            }
        }


        public DataTable Consultar(string busca)
        {
            MySqlConnection cnx = new MySqlConnection(metodos.conectaDBMySql());
            try
            {
                cnx.Open();
                MySqlCommand comando = new MySqlCommand("SELECT m.id,artista," +
                    "m.nroFaixa ,m.titulo, m.album, g.descricao as genero FROM" +
                    " tbl_musicas as m LEFT JOIN tbl_genero as g" +
                    " on m.idGenero = g.idGenero where" +
                    " m.titulo LIKE '%"+ busca +
                    "%' order by m.artista,m.nroFaixa", cnx);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                cnx.Close();
            }
        }
    }
}