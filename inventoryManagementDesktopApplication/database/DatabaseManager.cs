using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryManagementDesktopApplication.database
{
    internal class DatabaseManager
    {
        static string brand = "";
        public static void readTableArticle()
        {
            if (!string.IsNullOrEmpty(inventoryWindow.brand))
            {
                brand = "WHERE brand = '" + inventoryWindow.brand + "'";
            }


            try
            {
                MySqlConnection connection = DatabaseConnection.connection;
                string sql = "";

                if (!string.IsNullOrEmpty(brand))
                {
                    sql = "SELECT * FROM article " + brand;
                }
                else
                {
                    sql = "SELECT * FROM article";
                }
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2] + " -- " + rdr[3] + " -- " + rdr[4] + " -- " + rdr[5] + " -- " + rdr[6] + " -- " + rdr[7]);
                }
                rdr.Close();
                brand = "";
                Console.WriteLine("--------------------------------------------------------------------------------------");
            }
            catch
            {
                Console.WriteLine("Datensätze konnten nicht gelesen werden");
            }
        }
    }
}
