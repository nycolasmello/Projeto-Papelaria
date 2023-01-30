﻿using MySql.Data.MySqlClient;

namespace Projeto_Papelaria.DB
{
    public class DBConnections
    {
        public MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; database = schema_papelaria; uid = papelaria; pwd = Vi@r.1851");

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

    }
}