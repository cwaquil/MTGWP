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
            Random num = new Random();
            int Number = num.Next(1, 20);
            BitmapImage Img = new BitmapImage(new Uri(@"/Assets/Dado/dice" + Number.ToString() + ".png", UriKind.Relative));
            dice1.Source = Img;
        }
    }
}