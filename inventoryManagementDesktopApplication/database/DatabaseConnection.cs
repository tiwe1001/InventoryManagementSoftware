using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;

namespace inventoryManagementDesktopApplication
{
    class DatabaseConnection
    {
        public static MySqlConnection connection = new MySqlConnection();

        static string server = "127.0.0.1;";
        static string database = "inventorymanagementdb;";
        static string Uid;
        static string password;

        // get username an password from MainWindow TextBox
        public static void read(string uname, string pw)
        {

            Uid = uname + ";";
            password = pw + ";";
        }


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
