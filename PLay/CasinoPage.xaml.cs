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

namespace PLay
{
    public partial class CasinoPage : Page
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        Random rnd = new Random();
        int a, b, c;
        public CasinoPage()
        {
            InitializeComponent();
            firstImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\апельсин.jpg"));
            secondImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\апельсин.jpg"));
            thirdImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\апельсин.jpg"));
            DataContext = MainWindow.CurrentUser;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {        
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            a = rnd.Next(1,6);
            b = rnd.Next(1,6);
            c = rnd.Next(1,6);
            switch (a)
            {
                case 1:
                    firstImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\апельсин.jpg"));
                    break;
                case 2:
                    firstImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\банан.jpg"));
                    break;
                case 3:
                    firstImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\киви.jpg"));
                    break;
                case 4:
                    firstImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\ананас.jpg"));
                    break;
                case 5:
                    firstImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\лимон.jpg"));
                    break;
            }
            switch (b)
            {
                case 1:
                    secondImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\апельсин.jpg"));
                    break;
                case 2:
                    secondImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\банан.jpg"));
                    break;
                case 3:
                    secondImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\киви.jpg"));
                    break;
                case 4:
                    secondImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\ананас.jpg"));
                    break;
                case 5:
                    secondImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\лимон.jpg"));
                    break;
            }
            switch (c)
            {
                case 1:
                    thirdImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\апельсин.jpg"));
                    break;
                case 2:
                    thirdImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\банан.jpg"));
                    break;
                case 3:
                    thirdImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\киви.jpg"));
                    break;
                case 4:
                    thirdImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\ананас.jpg"));
                    break;
                case 5:
                    thirdImage.Source = new BitmapImage(new Uri("C:\\Users\\nasur\\source\\repos\\PLay\\PLay\\лимон.jpg"));
                    break;
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            if (firstImage.Source.ToString() == secondImage.Source.ToString() && secondImage.Source.ToString() == thirdImage.Source.ToString())
                MainWindow.CurrentUser.Score += 1000;
            else if (firstImage.Source.ToString() == secondImage.Source.ToString())
                MainWindow.CurrentUser.Score += 500;
            else if (thirdImage.Source.ToString() == secondImage.Source.ToString())
                MainWindow.CurrentUser.Score += 500;
            else if (thirdImage.Source.ToString() == firstImage.Source.ToString())
                MainWindow.CurrentUser.Score += 500;
            BdConnection.Connection.SaveChanges();
            tbScore.Text = MainWindow.CurrentUser.Score.ToString();
        }
    }
}
