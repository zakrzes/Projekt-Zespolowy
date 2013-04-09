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

namespace FancyMaths
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Klasa_pierwsza.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 3.5 / 100), (((SystemParameters.WorkArea.Height) * 47) / 100), (((SystemParameters.WorkArea.Width) * 75) / 100), (((SystemParameters.WorkArea.Height) * 46) / 100));
            Klasa_druga.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 14 / 100), (((SystemParameters.WorkArea.Height) * 64) / 100), (((SystemParameters.WorkArea.Width) * 64) / 100), (((SystemParameters.WorkArea.Height) * 29) / 100));
            Klasa_trzecia.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 24 / 100), (((SystemParameters.WorkArea.Height) * 82) / 100), (((SystemParameters.WorkArea.Width) * 53) / 100), (((SystemParameters.WorkArea.Height) * 11) / 100));
            Exit.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 97 / 100), 0, 0, (((SystemParameters.WorkArea.Height) * 96.5) / 100));
        }

        private void Button_size()
        {
        }

        private void Klasa_pierwsza_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Klasa_Pierwsza();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Klasa_druga_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Klasa_Druga();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Klasa_trzecia_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Klasa_Trzecia();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Zadania_z_trescia_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Zadania_z_Trescia();
            Window oldWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }        
    }
}
