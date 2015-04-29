using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Xml.Linq;

namespace MTGWindowsPhone.Entidades
{
    public partial class Wishlist : PhoneApplicationPage
    {
        List<Card> listaCartas = new List<Card>();
        public Wishlist()
        {
            InitializeComponent();

            WebClient webCartas = new WebClient();
            webCartas.DownloadStringCompleted += webCartas_DownloadStringCompleted;

            Uri jsonFile = new Uri("http://api.mtgdb.info");

        }

        void webCartas_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null) return;

            XElement jsonCarta = XElement.Parse(e.Result);

            foreach (XElement card in jsonCarta.Elements("Card"))
            {
                Card carta = new Card()
                {
                    id = int.Parse(card.Element("id").Value),
                    name = card.Element("name").Value,
                    colors = new List<string>(),//                  card.Element("colors").Value,
                    type = card.Element("type").Value
                };
                listaCartas.Add(carta);
            }
            lstCartas.ItemsSource = listaCartas;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Visualizacoes/Buscar.xaml?titulo=",
                UriKind.RelativeOrAbsolute));
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var _action = MessageBox.Show("Deseja remover a carta da lista?",
                "Atenção", MessageBoxButton.OKCancel);

            if (_action == MessageBoxResult.OK)
            {
                //using (var _context = new CardContext(_connectionString))
                //{
                //    Card _carta = (lstCartas.SelectedItem as Card);

                //    _context.SubmitChanges();

                //    _carta = null;
                //}

            }
        }
    }
}