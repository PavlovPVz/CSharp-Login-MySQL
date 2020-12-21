using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Login_Panel
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=178.154.229.185;port=3306;username=gold1;password=MetaRa1nq10;database=onioncheat");

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
