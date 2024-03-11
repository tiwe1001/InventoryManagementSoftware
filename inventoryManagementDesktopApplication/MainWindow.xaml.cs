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
    /// 
    public partial class MainWindow : Window
    {
        public string username;
        public string password;

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
            username = usernameInput.Text;
            password = passwordInput.Password;
            DatabaseConnection.read(username, password); // username and password to DatabaseConnector

            try
            {
                DatabaseConnection.dataSource();
                conn.openConnection();
                Console.WriteLine("Connected!");
                lblNotConnected.Visibility = Visibility.Hidden;
                lblConnected.Visibility = Visibility.Visible;
                loginWrong.Visibility = Visibility.Hidden;

            }
            catch (Exception)
            {
                conn.closeConnection();
                loginWrong.Visibility = Visibility.Visible;
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
            loginWrong.Visibility = Visibility.Hidden;
            usernameInput.Text = "";
            passwordInput.Password = "";
        }

        public string read()
        {
            username = usernameInput.Text;
            Console.WriteLine(" Ausgabe: " + username);
            return username;
        }
    }
}
