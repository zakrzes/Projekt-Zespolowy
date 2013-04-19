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

namespace FancyMaths.Druga
{
    /// <summary>
    /// Interaction logic for Druga_Dodawanie.xaml
    /// </summary>
    public partial class Druga_Dodawanie : Window
    {
        double height = 0;
        double width = 0;
        double left = 0;
        double left_wynik = 0;
        int liczba = 0;
        int numberone = 0;
        int numbertwo = 0;
        double bottom = 0;
        public Druga_Dodawanie()
        {
            Random rnd = new Random();
            InitializeComponent();
            numberone = rnd.Next(1, 49);
            numbertwo = rnd.Next(1, (50 - numberone));
            height = (SystemParameters.WorkArea.Height) * 30 / 100;
            width = (SystemParameters.WorkArea.Width) * 12.5 / 100;
            bottom = (SystemParameters.WorkArea.Height) * 40 / 100;
            showpictures(numberone, numbertwo);

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
            Sprawdz.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 83 / 100), (((SystemParameters.WorkArea.Height) * 60) / 100), (((SystemParameters.WorkArea.Width) * 3) / 100), (((SystemParameters.WorkArea.Height) * 37) / 100));
            Sprawdz_image.Margin = new Thickness(((SystemParameters.WorkArea.Width) * 83 / 100), (((SystemParameters.WorkArea.Height) * 60) / 100), (((SystemParameters.WorkArea.Width) * 3) / 100), (((SystemParameters.WorkArea.Height) * 37) / 100));
        }

        private void showpictures(int numberone, int numbertwo)
        {
            left = 0;
            if (numberone >= 10)
            {
                Image item = new Image();
                item.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l" + (numberone / 10) + ".gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item);
                item.Width = width;
                item.Height = height;
                item.Margin = new Thickness(left, 0, (SystemParameters.WorkArea.Width - left - width), bottom);
                left += width;
            }
            
                Image item2 = new Image();
                item2.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l"+(numberone%10)+".gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item2);
                item2.Width = width;
                item2.Height = height;
                item2.Margin = new Thickness(left, 0, (SystemParameters.WorkArea.Width - left - width), bottom);
                left += width;

            Image plus = new Image();
            plus.Source = new BitmapImage(new Uri(@"../../Obrazki/plus.gif", UriKind.RelativeOrAbsolute));
            Grid2.Children.Add(plus);
            plus.Width = width/2;
            plus.Height = height/2;
            plus.Margin = new Thickness(left, 0, (SystemParameters.WorkArea.Width - left - width), bottom);
            left += width;
            if (numbertwo >= 10)
            {
                Image item3 = new Image();
                item3.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l" + (numbertwo / 10) + ".gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item3);
                item3.Width = width;
                item3.Height = height;
                item3.Margin = new Thickness(left, 0, (SystemParameters.WorkArea.Width - left - width), bottom);
                left += width;
            }

            Image item4 = new Image();
            item4.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l" + (numbertwo % 10) + ".gif", UriKind.RelativeOrAbsolute));
            Grid2.Children.Add(item4);
            item4.Width = width;
            item4.Height = height;
            item4.Margin = new Thickness(left, 0, (SystemParameters.WorkArea.Width - left - width), bottom);
            left += width;


            Image item5 = new Image();
            item5.Source = new BitmapImage(new Uri(@"../../Obrazki/=.gif", UriKind.RelativeOrAbsolute));
            Grid2.Children.Add(item5);
            item5.Width = width/2;
            item5.Height = height/2;
            item5.Margin = new Thickness(left, 0, (SystemParameters.WorkArea.Width - left - width), bottom);
            left_wynik = left + width;
            liczba = 0;
           
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (liczba < 10)
            {
                Image item5 = new Image();
                item5.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l0.gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item5);
                item5.Width = width;
                item5.Height = height;
                item5.Margin = new Thickness(left_wynik, 0, (SystemParameters.WorkArea.Width - left_wynik - width), bottom);
                left_wynik += width;
                if (liczba > 0) liczba *= 10;
            }
        }

        private void Jeden_Click(object sender, RoutedEventArgs e)
        {
            if (liczba < 10)
            {
                Image item5 = new Image();
                item5.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l1.gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item5);
                item5.Width = width;
                item5.Height = height;
                item5.Margin = new Thickness(left_wynik, 0, (SystemParameters.WorkArea.Width - left_wynik - width), bottom);
                left_wynik += width;
                if (liczba > 0) liczba *= 10;
                liczba += 1;
            }
        }

        private void Dwa_Click(object sender, RoutedEventArgs e)
        {
            if (liczba < 10)
            {
                Image item5 = new Image();
                item5.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l2.gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item5);
                item5.Width = width;
                item5.Height = height;
                item5.Margin = new Thickness(left_wynik, 0, (SystemParameters.WorkArea.Width - left_wynik - width), bottom);
                left_wynik += width;
                if (liczba > 0) liczba *= 10;
                liczba += 2;
            }
        }

        private void Trzy_Click(object sender, RoutedEventArgs e)
        {
            if (liczba < 10)
            {
                Image item5 = new Image();
                item5.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l3.gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item5);
                item5.Width = width;
                item5.Height = height;
                item5.Margin = new Thickness(left_wynik, 0, (SystemParameters.WorkArea.Width - left_wynik - width), bottom);
                left_wynik += width;
                if (liczba > 0) liczba *= 10;
                liczba += 3;
            }
        }

        private void Cztery_Click(object sender, RoutedEventArgs e)
        {
            if (liczba < 10)
            {
                Image item5 = new Image();
                item5.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l4.gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item5);
                item5.Width = width;
                item5.Height = height;
                item5.Margin = new Thickness(left_wynik, 0, (SystemParameters.WorkArea.Width - left_wynik - width), bottom);
                left_wynik += width;
                if (liczba > 0) liczba *= 10;
                liczba += 4;
            }
        }

        private void Piec_Click(object sender, RoutedEventArgs e)
        {
            if (liczba < 10)
            {
                Image item5 = new Image();
                item5.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l5.gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item5);
                item5.Width = width;
                item5.Height = height;
                item5.Margin = new Thickness(left_wynik, 0, (SystemParameters.WorkArea.Width - left_wynik - width), bottom);
                left_wynik += width;
                if (liczba > 0) liczba *= 10;
                liczba += 5;
            }
        }

        private void Szesc_Click(object sender, RoutedEventArgs e)
        {
            if (liczba < 10)
            {
                Image item5 = new Image();
                item5.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l6.gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item5);
                item5.Width = width;
                item5.Height = height;
                item5.Margin = new Thickness(left_wynik, 0, (SystemParameters.WorkArea.Width - left_wynik - width), bottom);
                left_wynik += width;
                if (liczba > 0) liczba *= 10;
                liczba += 6;
            }
        }

        private void Siedem_Click(object sender, RoutedEventArgs e)
        {
            if (liczba < 10)
            {
                Image item5 = new Image();
                item5.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l7.gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item5);
                item5.Width = width;
                item5.Height = height;
                item5.Margin = new Thickness(left_wynik, 0, (SystemParameters.WorkArea.Width - left_wynik - width), bottom);
                left_wynik += width;
                if (liczba > 0) liczba *= 10;
                liczba += 7;
            }
        }

        private void Osiem_Click(object sender, RoutedEventArgs e)
        {
            if (liczba < 10)
            {
                Image item5 = new Image();
                item5.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l8.gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item5);
                item5.Width = width;
                item5.Height = height;
                item5.Margin = new Thickness(left_wynik, 0, (SystemParameters.WorkArea.Width - left_wynik - width), bottom);
                left_wynik += width;
                if (liczba > 0) liczba *= 10;
                liczba += 8;
            }
        }

        private void Dziewiec_Click(object sender, RoutedEventArgs e)
        {
            if (liczba < 10)
            {
                Image item5 = new Image();
                item5.Source = new BitmapImage(new Uri(@"../../Obrazki/liczby/l9.gif", UriKind.RelativeOrAbsolute));
                Grid2.Children.Add(item5);
                item5.Width = width;
                item5.Height = height;
                item5.Margin = new Thickness(left_wynik, 0, (SystemParameters.WorkArea.Width - left_wynik - width), bottom);
                left_wynik += width;
                if (liczba > 0) liczba *= 10;
                liczba += 9;
            }
        }

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            if (liczba == (numberone + numbertwo))
            {
                Random rnd = new Random();
                MessageBox.Show("dobrze");
                Grid2.Children.Clear();
                numberone = rnd.Next(1, 50);
                numbertwo = rnd.Next(1, (50 - numberone));
                showpictures(numberone, numbertwo);
            }
            else
            {
                MessageBox.Show("zle");
                if (left_wynik > (left + (2*width)))
                {
                    Grid2.Children.RemoveAt(Grid2.Children.Count - 1);
                    Grid2.Children.RemoveAt(Grid2.Children.Count - 1);
                }
                else if (left_wynik == (left + (2*width)))
                {
                    Grid2.Children.RemoveAt(Grid2.Children.Count - 1);
                }
                left_wynik = left + width;
                liczba = 0;
            }

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
