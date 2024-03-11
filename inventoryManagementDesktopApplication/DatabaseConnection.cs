using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace inventoryManagementDesktopApplication
{
    class DatabaseConnection
    {
        public static MySqlConnection connection = new MySqlConnection();

        static string server = "127.0.0.1;";
        static string database = "inventorymanagementdb;";
        static string Uid = "root;";
        static string password = ";";

        public static MySqlConnection dataSource()
        {
            connection = new MySqlConnection($"server={server} database={database} Uid={Uid} password={password}");

            return connection;
        }

        public void openConnection()
        {
            dataSource();
            connection.Open();
        }

        public void closeConnection()
        {
            dataSource();
            connection.Close();
        }

    }
}
