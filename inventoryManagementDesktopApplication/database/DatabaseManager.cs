﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace inventoryManagementDesktopApplication.database
{
    internal class DatabaseManager
    {
        static string brand = "";
        static List<Product> products = new List<Product>();
        public static void readTableArticle()
        {
            clearProductList();

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
                    int id = rdr.GetInt32(0);
                    string brand = rdr.GetString(1);
                    string name = rdr.GetString(2);
                    string description = rdr.GetString(3);
                    string category = rdr.GetString(4);
                    int quantity = rdr.GetInt32(5);
                    double price = rdr.GetDouble(6);
                    DateTime date = rdr.GetDateTime(7);

                    Product product = new Product(id, brand, name, description, category, quantity, price, date);
                    products.Add(product);

//                    Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2] + " -- " + rdr[3] + " -- " + rdr[4] + " -- " + rdr[5] + " -- " + rdr[6] + " -- " + rdr[7]);
                    }

                foreach (Product product in products)
                {
                    Console.WriteLine($"ID: {product.id}, Marke: {product.brand}, Name: {product.name}, Beschreibung: {product.description}, Kategorie: {product.category}, Menge: {product.quantity}, Preis: {product.price}, Datum: {product.date}");
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

        public static List<Product> getProducts()
        {
            return products;
        }

        public static void clearProductList()
        {
            products.Clear();
        }
    }
}
