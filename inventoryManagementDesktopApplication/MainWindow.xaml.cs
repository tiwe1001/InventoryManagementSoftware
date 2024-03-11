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
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace inventoryManagementDesktopApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DatabaseConnection conn = new DatabaseConnection();

        public MainWindow()
        {
            InitializeComponent();
            lblConnected.Visibility = Visibility.Hidden;
            lblNotConnected.Visibility = Visibility.Visible;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            addArticleWindow addArticle = new addArticleWindow();

            addArticle.Show();
        }

        private void btnConn_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                DatabaseConnection.dataSource();
                conn.openConnection();
                Console.WriteLine("Connected!");
                lblNotConnected.Visibility = Visibility.Hidden;
                lblConnected.Visibility = Visibility.Visible;
                
            }
            catch (Exception)
            {
                conn.closeConnection();
                Console.WriteLine("Connection error!");
                lblConnected.Visibility = Visibility.Hidden;
                lblNotConnected.Visibility = Visibility.Visible;
            }
        }

        private void btnDisconn_Click(object sender, RoutedEventArgs e)
        {
            conn.closeConnection();
            Console.WriteLine("Connection closed!");
            lblConnected.Visibility = Visibility.Hidden;
            lblNotConnected.Visibility = Visibility.Visible;
        }
    }
}
