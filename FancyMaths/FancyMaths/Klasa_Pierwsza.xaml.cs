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

namespace FancyMaths
{
    /// <summary>
    /// Interaction logic for Klasa_Pierwsza.xaml
    /// </summary>
    public partial class Klasa_Pierwsza : Window
    {
        public Klasa_Pierwsza()
        {
            InitializeComponent();

            Grid1.Margin = new Thickness(1,1,1,1);
        }

        private void Pierwsza_dodawanie_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Pierwsza.Pierwsza_Dodawanie();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Pierwsza_odejmowanie_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Pierwsza.Pierwsza_Odejmowanie();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Pierwsza_dod_i_odej_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Pierwsza.Pierwsza_Dod_i_Odej();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Pierwsza_zaleznosci_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Pierwsza.Pierwsza_Zaleznosci();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new MainWindow();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }
    }
}
