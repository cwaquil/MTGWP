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
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Threading;

namespace MTGWindowsPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        private Popup popup;
        private BackgroundWorker backgroundWorker;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ShowPopup();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void ShowPopup()
        {
            popup = new Popup();
            popup.Child = new PopupSplash();
            popup.IsOpen = true;

            StartLoadingData();
        }

        private void StartLoadingData()
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);

            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(() =>
            {
                this.popup.IsOpen = false;

            }
               );
        }

        void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            //data Loading
            Thread.Sleep(5000);
            
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