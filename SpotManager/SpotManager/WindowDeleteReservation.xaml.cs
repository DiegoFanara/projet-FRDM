﻿using System;
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
    /// Interaction logic for WindowDeleteReservation.xaml
    /// </summary>
    public partial class WindowDeleteReservation : Window
    {
        public WindowDeleteReservation()
        {
            InitializeComponent();
        }

        private void abortButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void deleteButton(object sender, RoutedEventArgs e) 
        {
            this.Close();
        }
    }
}
