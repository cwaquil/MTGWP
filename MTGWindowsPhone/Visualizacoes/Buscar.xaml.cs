using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MTGWindowsPhone.Controles;

namespace MTGWindowsPhone.Entidades
{
    public partial class Buscar : PhoneApplicationPage
    {
        String[] Forca = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        String[] Resistencia = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        String[] CMC = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public Buscar()
        {
            InitializeComponent();

            this.lpkForca.ItemsSource = Forca;
            this.lpkResistencia.ItemsSource = Resistencia;
            this.lpkCMC.ItemsSource = CMC;
        }

        private void chkBranca_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void chkPreta_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void chkAzul_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void chkVerde_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void chkVermelha_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            DownloadInfoControle2 dic = new DownloadInfoControle2();
            dic.getCard();
            NavigationService.Navigate(new Uri("/Visualizacoes/resultadoBusca.xaml?titulo=",
                UriKind.RelativeOrAbsolute));
        }

    }
}