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

namespace FancyMaths.Trzecia
{
    public partial class Trzecia_Dodawanie : Window
    {
    	private double workAreaWidth;
    	private double workAreaHeight;
    	
    	private Image [] anwserTab = new Image[4];
    	
    	private int anwserTabIndex;
    	
    	int add1Int;
        int add2Int;
        int sumInt;
        
        Uri selectImageUri;
        
        string sumStr;
        string anwserStr = "";

        string digitUriPrefix;
    	
        public Trzecia_Dodawanie()
        {
            InitializeComponent();
            
            this.workAreaWidth = SystemParameters.WorkArea.Width;
    		this.workAreaHeight = SystemParameters.WorkArea.Height;

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
            
            Grid2.Margin = new Thickness(workAreaWidth * 0.22, workAreaHeight * 0.20, workAreaWidth * 0.22, workAreaHeight * 0.35);
            title.Margin = new Thickness(workAreaWidth * 0.10, workAreaHeight * 0.02, workAreaWidth * 0.10, workAreaHeight * 0.85);
            
            
            this.selectImageUri = new Uri(@"../../Obrazki/select.png", UriKind.Relative);
            
            this.anwserTab[0] = sum_1;
            this.anwserTab[1] = sum_2;
            this.anwserTab[2] = sum_3;
            this.anwserTab[3] = sum_4;
            
            this.anwserTabIndex = 0;

            this.digitUriPrefix = @"../../Obrazki/liczby/cyfra-";
            

            stats1.Source = new BitmapImage(new Uri(@"../../Obrazki/sprawdz.png", UriKind.Relative));
            stats2.Source = new BitmapImage(new Uri(@"../../Obrazki/dobrze.png", UriKind.Relative));
            stats3.Source = new BitmapImage(new Uri(@"../../Obrazki/powtorz.png", UriKind.Relative));
            stats4.Source = new BitmapImage(new Uri(@"../../Obrazki/nastepne.png", UriKind.Relative));
          
            add_2_4.Source = new BitmapImage(new Uri(@"../../Obrazki/plus.gif", UriKind.Relative));
            
            Generate();
        }

        private void Generate()
        {
            Random random = new Random();

            this.add1Int = random.Next(50, 200);
            this.add2Int = random.Next(50, 200);
            this.sumInt = add1Int + add2Int;

            string add1Str = add1Int.ToString();
            string add2Str = add2Int.ToString();
            this.sumStr = sumInt.ToString();

            if (add1Str.Length == 1)
            {
                add_1_1.Source = new BitmapImage(new Uri(this.digitUriPrefix + add1Str[0] + ".png", UriKind.Relative));
                add_1_2.Source = null;
                add_1_3.Source = null;
            }
            if (add1Str.Length == 2)
            {
                add_1_1.Source = new BitmapImage(new Uri(this.digitUriPrefix + add1Str[1] + ".png", UriKind.Relative));
                add_1_2.Source = new BitmapImage(new Uri(this.digitUriPrefix + add1Str[0] + ".png", UriKind.Relative));
                add_1_3.Source = null;
            }
            if (add1Str.Length == 3)
            {
                add_1_1.Source = new BitmapImage(new Uri(this.digitUriPrefix + add1Str[2] + ".png", UriKind.Relative));
                add_1_2.Source = new BitmapImage(new Uri(this.digitUriPrefix + add1Str[1] + ".png", UriKind.Relative));
                add_1_3.Source = new BitmapImage(new Uri(this.digitUriPrefix + add1Str[0] + ".png", UriKind.Relative));
            }


            if (add2Str.Length == 1)
            {
                add_2_1.Source = new BitmapImage(new Uri(this.digitUriPrefix + add2Str[0] + ".png", UriKind.Relative));
                add_2_2.Source = null;
                add_2_3.Source = null;
            }
            if (add2Str.Length == 2)
            {
                add_2_1.Source = new BitmapImage(new Uri(this.digitUriPrefix + add2Str[1] + ".png", UriKind.Relative));
                add_2_2.Source = new BitmapImage(new Uri(this.digitUriPrefix + add2Str[0] + ".png", UriKind.Relative));
                add_2_3.Source = null;
            }
            if (add2Str.Length == 3)
            {
                add_2_1.Source = new BitmapImage(new Uri(this.digitUriPrefix + add2Str[2] + ".png", UriKind.Relative));
                add_2_2.Source = new BitmapImage(new Uri(this.digitUriPrefix + add2Str[1] + ".png", UriKind.Relative));
                add_2_3.Source = new BitmapImage(new Uri(this.digitUriPrefix + add2Str[0] + ".png", UriKind.Relative));
            }

            this.anwserTabIndex = 0;
            this.anwserStr = "";

            this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(this.selectImageUri);

            stats2.Source = null;

            sum_2.Source = null;
            sum_3.Source = null;
            sum_4.Source = null;
        }
        
        private void Zero_Click(object sender, RoutedEventArgs e)
        {
        	if (this.anwserTabIndex < this.sumStr.Length)
        	{
            	this.anwserStr = "0" + this.anwserStr;

                this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(new Uri(this.digitUriPrefix + "0" + ".png", UriKind.Relative));
            	this.anwserTabIndex += 1;
            	
            	if (this.anwserTabIndex < this.sumStr.Length)
            		this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(this.selectImageUri);
        	}
        }

        private void Jeden_Click(object sender, RoutedEventArgs e)
        {
            if (this.anwserTabIndex < this.sumStr.Length)
            {
                this.anwserStr = "1" + this.anwserStr;

                this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(new Uri(this.digitUriPrefix + "1" + ".png", UriKind.Relative));
                this.anwserTabIndex += 1;

                if (this.anwserTabIndex < this.sumStr.Length)
                    this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(this.selectImageUri);
            }
        }

        private void Dwa_Click(object sender, RoutedEventArgs e)
        {
            if (this.anwserTabIndex < this.sumStr.Length)
            {
                this.anwserStr = "2" + this.anwserStr;

                this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(new Uri(this.digitUriPrefix + "2" + ".png", UriKind.Relative));
                this.anwserTabIndex += 1;

                if (this.anwserTabIndex < this.sumStr.Length)
                    this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(this.selectImageUri);
            }
        }

        private void Trzy_Click(object sender, RoutedEventArgs e)
        {
            if (this.anwserTabIndex < this.sumStr.Length)
            {
                this.anwserStr = "3" + this.anwserStr;

                this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(new Uri(this.digitUriPrefix + "3" + ".png", UriKind.Relative));
                this.anwserTabIndex += 1;

                if (this.anwserTabIndex < this.sumStr.Length)
                    this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(this.selectImageUri);
            }
        }

        private void Cztery_Click(object sender, RoutedEventArgs e)
        {
            if (this.anwserTabIndex < this.sumStr.Length)
            {
                this.anwserStr = "4" + this.anwserStr;

                this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(new Uri(this.digitUriPrefix + "4" + ".png", UriKind.Relative));
                this.anwserTabIndex += 1;

                if (this.anwserTabIndex < this.sumStr.Length)
                    this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(this.selectImageUri);
            }
        }

        private void Piec_Click(object sender, RoutedEventArgs e)
        {
            if (this.anwserTabIndex < this.sumStr.Length)
            {
                this.anwserStr = "5" + this.anwserStr;

                this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(new Uri(this.digitUriPrefix + "5" + ".png", UriKind.Relative));
                this.anwserTabIndex += 1;

                if (this.anwserTabIndex < this.sumStr.Length)
                    this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(this.selectImageUri);
            }
        }

        private void Szesc_Click(object sender, RoutedEventArgs e)
        {
            if (this.anwserTabIndex < this.sumStr.Length)
            {
                this.anwserStr = "6" + this.anwserStr;

                this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(new Uri(this.digitUriPrefix + "6" + ".png", UriKind.Relative));
                this.anwserTabIndex += 1;

                if (this.anwserTabIndex < this.sumStr.Length)
                    this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(this.selectImageUri);
            }
        }

        private void Siedem_Click(object sender, RoutedEventArgs e)
        {
            if (this.anwserTabIndex < this.sumStr.Length)
            {
                this.anwserStr = "7" + this.anwserStr;

                this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(new Uri(this.digitUriPrefix + "7" + ".png", UriKind.Relative));
                this.anwserTabIndex += 1;

                if (this.anwserTabIndex < this.sumStr.Length)
                    this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(this.selectImageUri);
            }
        }

        private void Osiem_Click(object sender, RoutedEventArgs e)
        {
            if (this.anwserTabIndex < this.sumStr.Length)
            {
                this.anwserStr = "8" + this.anwserStr;

                this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(new Uri(this.digitUriPrefix + "8" + ".png", UriKind.Relative));
                this.anwserTabIndex += 1;

                if (this.anwserTabIndex < this.sumStr.Length)
                    this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(this.selectImageUri);
            }
        }

        private void Dziewiec_Click(object sender, RoutedEventArgs e)
        {
            if (this.anwserTabIndex < this.sumStr.Length)
            {
                this.anwserStr = "9" + this.anwserStr;

                this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(new Uri(this.digitUriPrefix + "9" + ".png", UriKind.Relative));
                this.anwserTabIndex += 1;

                if (this.anwserTabIndex < this.sumStr.Length)
                    this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(this.selectImageUri);
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

        private void stats1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (this.sumStr == this.anwserStr)
            {
                stats2.Source = new BitmapImage(new Uri(@"../../Obrazki/dobrze.png", UriKind.Relative));
            }
            else
            {
                stats2.Source = new BitmapImage(new Uri(@"../../Obrazki/zle.png", UriKind.Relative));
            }
        }

        private void stats3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.anwserTabIndex = 0;
            this.anwserStr = "";

            this.anwserTab[this.anwserTabIndex].Source = new BitmapImage(this.selectImageUri);

            stats2.Source = null;

            sum_2.Source = null;
            sum_3.Source = null;
            sum_4.Source = null;
        }

        private void stats4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Generate();
        }
    }
}
