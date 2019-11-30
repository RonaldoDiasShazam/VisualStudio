using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CalculadoraTurmaB
{
    class ModelLogin
    {

        MetodosUteis metodos = new MetodosUteis();
        public int InserirLogin(Login login)
        {

            MySqlConnection cnx = new MySqlConnection(metodos.conectaDBMySql());
            int count;
            cnx.Open();

            MySqlCommand comando = new MySqlCommand("INSERT into" + 
                " tbl_login (login,senha) VALUES('"+ login.login + "','"+ login.senha +"')",cnx);

            count = comando.ExecuteNonQuery();

            cnx.Close();
            return 0;

        }
    }
}