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
    /// Interaction logic for Klasa_Druga.xaml
    /// </summary>
    public partial class Klasa_Druga : Window
    {
        public Klasa_Druga()
        {
            InitializeComponent();

            Grid2.Margin = new Thickness(1, 1, 1, 1);
        }

        private void Druga_dodawanie_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Druga.Druga_Dodawanie();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Druga_odejmowanie_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Druga.Druga_Odejmowanie();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Druga_dod_i_odej_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Druga.Druga_Dod_i_Odej();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Druga_zaleznosci_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Druga.Druga_Zaleznosci();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Powrot_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new MainWindow();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }


       
    }
}
