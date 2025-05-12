using System.Windows;
using System.Windows.Navigation;

namespace SpotManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void seConnecter(object sender, RoutedEventArgs e)
        {
            var homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
    }
}