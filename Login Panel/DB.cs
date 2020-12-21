using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Login_Panel
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=ip;port=3306;username=user;password=pass;database=onioncheat");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
