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

        public inventoryWindow()
        {
            InitializeComponent();
        }

        private void BtnAddArticle_Click(object sender, RoutedEventArgs e)
        {
            addArticleWindow addArticle = new addArticleWindow();

            addArticle.Show();
        }

        private void BtnSearchArticle_Click(object sender, RoutedEventArgs e)
        {
            brand = brandSearch.Text;
            DatabaseManager.readTableArticle();
        }
    }
}
