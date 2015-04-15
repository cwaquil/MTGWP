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

    public partial class Moeda : PhoneApplicationPage
    {


        public Moeda()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Storyboard1.Begin();
            Random num = new Random();
            int Number = num.Next(1, 3);
            BitmapImage Img = new BitmapImage(new Uri(@"/Assets/Moeda/moeda" + Number.ToString() + ".png", UriKind.Relative));
            moeda1.Source = Img;
        }
    }



}