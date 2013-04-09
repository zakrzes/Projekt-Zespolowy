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
    /// Interaction logic for Klasa_Trzecia.xaml
    /// </summary>
    public partial class Klasa_Trzecia : Window
    {
        public Klasa_Trzecia()
        {
            InitializeComponent();

            Grid3.Margin = new Thickness(1, 1, 1, 1);
        }

        private void Trzecia_dodawanie_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Trzecia.Trzecia_Dodawanie();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Trzecia_odejmowanie_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Trzecia.Trzecia_Odejmowanie();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Trzecia_mnozenie_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Trzecia.Trzecia_Mnozenie();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Trzecia_dzielenie_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Trzecia.Trzecia_Dzielenie();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Trzecia_dod_i_odej_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Trzecia.Trzecia_Dod_i_Odej();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Trzecia_mno_i_dziel_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Trzecia.Trzecia_Mno_i_Dziel();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Trzecia_liczby_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Trzecia.Trzecia_Liczby();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Trzecia_tresc_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Trzecia.Trzecia_Tresc();
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
