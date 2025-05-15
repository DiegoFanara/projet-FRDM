using System.Windows;
using System.Windows.Controls;

namespace SpotManager
{
    /// <summary>
    /// Logique d'interaction pour HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void disconnectBtn(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void newReservationBtn(object sender, RoutedEventArgs e)
        {
            var windowCreationReservation = new WindowCreationReservation();
            windowCreationReservation.Show();
        }

        private void deleteReservationBtn(object sender, RoutedEventArgs e)
        {
            var windowDeleteReservation = new WindowDeleteReservation();
            windowDeleteReservation.Show();
        }
        private void localReservationBtn(object sender, RoutedEventArgs e)
        {
            var windowReservationLocal = new WindowReservationLocal();
            windowReservationLocal.Show();
        }
    }
}
