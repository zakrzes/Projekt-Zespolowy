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

namespace FancyMaths.Pierwsza
{
    /// <summary>
    /// Interaction logic for Pierwsza_Dodawanie.xaml
    /// </summary>
    public partial class Pierwsza_Dodawanie : Window
    {
        public Pierwsza_Dodawanie()
        {
            InitializeComponent();

            Grid1.Margin = new Thickness(1, 1, 1, 1);
            Zero.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 3 / 100), (((SystemParameters.WorkArea.Height) * 85) / 100), (((SystemParameters.WorkArea.Width) * 90) / 100), (((SystemParameters.WorkArea.Height) * 7) / 100));
            Jeden.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 14 / 100), (((SystemParameters.WorkArea.Height) * 77) / 100), (((SystemParameters.WorkArea.Width) * 80.5) / 100), (((SystemParameters.WorkArea.Height) * 16) / 100));
            Dwa.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 24 / 100), (((SystemParameters.WorkArea.Height) * 86) / 100), (((SystemParameters.WorkArea.Width) * 69) / 100), (((SystemParameters.WorkArea.Height) * 6) / 100));
            Trzy.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 33 / 100), (((SystemParameters.WorkArea.Height) * 77) / 100), (((SystemParameters.WorkArea.Width) * 61) / 100), (((SystemParameters.WorkArea.Height) * 16) / 100));
            Cztery.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 43 / 100), (((SystemParameters.WorkArea.Height) * 86) / 100), (((SystemParameters.WorkArea.Width) * 50) / 100), (((SystemParameters.WorkArea.Height) * 6) / 100));
            Piec.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 54 / 100), (((SystemParameters.WorkArea.Height) * 77) / 100), (((SystemParameters.WorkArea.Width) * 39) / 100), (((SystemParameters.WorkArea.Height) * 14) / 100));
            Szesc.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 63 / 100), (((SystemParameters.WorkArea.Height) * 86) / 100), (((SystemParameters.WorkArea.Width) * 30) / 100), (((SystemParameters.WorkArea.Height) * 5) / 100));
            Siedem.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 73 / 100), (((SystemParameters.WorkArea.Height) * 76) / 100), (((SystemParameters.WorkArea.Width) * 20) / 100), (((SystemParameters.WorkArea.Height) * 15) / 100));
            Osiem.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 80 / 100), (((SystemParameters.WorkArea.Height) * 88) / 100), (((SystemParameters.WorkArea.Width) * 12) / 100), (((SystemParameters.WorkArea.Height) * 3) / 100));
            Dziewiec.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 89 / 100), (((SystemParameters.WorkArea.Height) * 76) / 100), (((SystemParameters.WorkArea.Width) * 3) / 100), (((SystemParameters.WorkArea.Height) * 15) / 100));
            Exit.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 90 / 100), 0, 0, (((SystemParameters.WorkArea.Height) * 96.5) / 100));
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Jeden_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Dwa_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Trzy_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Cztery_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Piec_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Szesc_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Siedem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Osiem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Dziewiec_Click(object sender, RoutedEventArgs e)
        {
            
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
