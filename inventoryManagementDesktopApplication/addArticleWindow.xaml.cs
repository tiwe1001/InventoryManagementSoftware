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
    /// Interaktionslogik für addArticleWindow.xaml
    /// </summary>
    public partial class addArticleWindow : Window
    {
        public addArticleWindow()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
