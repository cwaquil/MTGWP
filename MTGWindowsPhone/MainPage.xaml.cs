using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MTGWindowsPhone.Resources;

namespace MTGWindowsPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btnGreen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Visualizacoes/Info.xaml?titulo=",
                UriKind.RelativeOrAbsolute));
        }

        private void btnBlack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Visualizacoes/Buscar.xaml?titulo=",
                UriKind.RelativeOrAbsolute));
        }

        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Visualizacoes/Moeda.xaml?titulo=",
                UriKind.RelativeOrAbsolute));
        }

        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Visualizacoes/Dado.xaml?titulo=",
                UriKind.RelativeOrAbsolute));
        }

        private void btnWhite_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Visualizacoes/Wishlist.xaml?titulo=",
                UriKind.RelativeOrAbsolute));
        }

        
    }
}