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
using MTGWindowsPhone.Data;

namespace MTGWindowsPhone.Entidades
{
    public partial class Buscar : PhoneApplicationPage
    {
        String[] Forca = { "", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        String[] Resistencia = { "", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        String[] CMC = { "", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
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

        private async void btnBuscar_Click(object sender, RoutedEventArgs e)
        {


            List<String> colors = new List<string>();
            if (this.chkAzul.IsChecked == true)
            {
                colors.Add("blue");
            }
            if (this.chkBranca.IsChecked == true)
            {
                colors.Add("white");
            }
            if (this.chkPreta.IsChecked == true)
            {
                colors.Add("black");
            }
            if (this.chkVerde.IsChecked == true)
            {
                colors.Add("green");
            }
            if (this.chkVermelha.IsChecked == true)
            {
                colors.Add("red");
            }
            
            BuscaCardTO bcTO = new BuscaCardTO(this.txtNome.Text, this.txtTipo.Text, this.txtSubtipo.Text, colors, this.lpkForca.SelectedItem.ToString(), this.lpkResistencia.SelectedItem.ToString(), this.lpkCMC.SelectedItem.ToString());

            PhoneApplicationService.Current.State["param"] = bcTO;
            
            NavigationService.Navigate(new Uri("/Visualizacoes/resultadoBusca.xaml?titulo=",
            UriKind.RelativeOrAbsolute));
        }

    }
}