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

namespace SpotManager
{
    /// <summary>
    /// Logique d'interaction pour WindowReservationLocal.xaml
    /// </summary>
    public partial class WindowReservationLocal : Window
    {
        public WindowReservationLocal()
        {
            InitializeComponent();
        }
        private void annulerBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
