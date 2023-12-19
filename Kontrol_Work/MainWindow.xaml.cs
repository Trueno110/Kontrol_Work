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

namespace Kontrol_Work
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFraim.Content = new MainFraim();
        }
     

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            MainFraim.Content = new Customers();
        }

        private void Marki_Click(object sender, RoutedEventArgs e)
        {
            MainFraim.Content = new Marki();
        }

        private void Sotrudniki_Click(object sender, RoutedEventArgs e)
        {
            MainFraim.Content = new Sotrudniki();
        }

        private void Auto_Click(object sender, RoutedEventArgs e)
        {
            MainFraim.Content = new Auto();
        }

        private void Selling_Click(object sender, RoutedEventArgs e)
        {
            MainFraim.Content = new Selling();
        }
    }
   
}

