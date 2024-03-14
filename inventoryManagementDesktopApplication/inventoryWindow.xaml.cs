using inventoryManagementDesktopApplication.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace inventoryManagementDesktopApplication
{
    /// <summary>
    /// Interaktionslogik für inventoryWindow.xaml
    /// </summary>
    public partial class inventoryWindow : Window
    {
        public static string brand;
        public static string price;
        public static string category;

        public inventoryWindow()
        {
            InitializeComponent();

            categorySearch.SelectedIndex = 0;
        }

        private void BtnAddArticle_Click(object sender, RoutedEventArgs e)
        {
            addArticleWindow addArticle = new addArticleWindow();

            addArticle.Show();
        }

        private void BtnSearchArticle_Click(object sender, RoutedEventArgs e)
        {
            dataTable.ItemsSource = null;
            brand = brandSearch.Text;
            price = priceSearch.Text;

            if (categorySearch.Text == "Select...")
            {
                category = "";
            } else
            {
                category = categorySearch.Text;
            }
            Console.WriteLine("Der Inhalt von Category = " + category);

            DatabaseManager.readTableArticle();

            dataTable.ItemsSource = DatabaseManager.getProducts();
        }
    }
}
