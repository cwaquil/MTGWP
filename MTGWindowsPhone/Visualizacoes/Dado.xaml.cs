using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace MTGWindowsPhone.Entidades
{
    public partial class Dado : PhoneApplicationPage
    {

        public Dado()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage Img;

            Storyboard1.Begin();

            //for (int roll = 1; roll <= 20; roll++)
            //{

            //    Img = new BitmapImage(new Uri(@"/Assets/Dado/dice" + roll.ToString() + ".png", UriKind.Relative));
            //    dice1.Source = Img;
            //    System.Threading.Thread.Sleep(500);

            //}

            Random num = new Random();
            int Number = num.Next(1, 20);
            Img = new BitmapImage(new Uri(@"/Assets/Dado/dice" + Number.ToString() + ".png", UriKind.Relative));
            dice1.Source = Img;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Storyboard1.Begin();
        }
    }
}