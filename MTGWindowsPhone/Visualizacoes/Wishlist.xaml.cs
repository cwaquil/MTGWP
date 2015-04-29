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
using MTGWindowsPhone.ModelView;

namespace MTGWindowsPhone.Entidades
{
    public partial class Wishlist : PhoneApplicationPage
    {
        private CardModelView CardMV;

        List<Card> listaCartas = new List<Card>();
        public Wishlist()
        {
            InitializeComponent();

            this.CardMV = new CardModelView();
            //this.CardMV.GetWishlist();  Remover
            //this.CardMV.SaveIsolated();  Remover
            this.CardMV.GetIsolated();

            this.DataContext = from card in CardMV.Wishlist
                               select card;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Visualizacoes/Buscar.xaml?titulo=",
                UriKind.RelativeOrAbsolute));
        }


        private void btnAddCard_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Visualizacoes/NovaCarta.xaml?titulo=",
                UriKind.RelativeOrAbsolute));
        }



        private void btnDel_Click(object sender, EventArgs e)
        {
            var _action = MessageBox.Show("Deseja remover a carta da lista?",
                "Atenção", MessageBoxButton.OKCancel);

            if (_action == MessageBoxResult.OK)
            {
                this.CardMV.Remove(sender.ToString()); // Todo:Enviar o nome da carta
            }
        }
    }
}