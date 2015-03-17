using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace MTGWindowsPhone.Entidades
{
    
    public partial class Moeda : PhoneApplicationPage
    {

        bool coinFlip = false;
        public Moeda()
        {
            this.InitializeComponent();
        }

        private void GridCard_Tapped(Object sender, TappedRoutedEventArgs e)
        {
            if (coinFlip == false)
            {
                Storyboard1.Begin();
                coinFlip = true;
            }
            else
            {
                Storyboard2.Begin();
                coinFlip = false;
            }
        }
    }

    

}