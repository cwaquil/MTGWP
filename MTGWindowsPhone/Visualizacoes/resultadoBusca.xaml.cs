using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MTGWindowsPhone.ModelView;
using MTGWindowsPhone.Data;
using MTGWindowsPhone.Entidades;
using MTGWindowsPhone.Controles;

namespace MTGWindowsPhone.Visualizacoes
{
    public partial class resultadoBusca : PhoneApplicationPage
    {
        private CardModelView CardMV;
        public resultadoBusca()
        {
            InitializeComponent();
            this.CardMV = new CardModelView();
            BuscaCardTO bcTO = PhoneApplicationService.Current.State["param"] as BuscaCardTO;
            loadCardList(bcTO);
        }

        private async void loadCardList(BuscaCardTO bcTO)
        {
            DownloadInfoControle2 dic = new DownloadInfoControle2();
            List<Card> cardList = await dic.getFilteredCards(bcTO.name, bcTO.type, bcTO.subtype, bcTO.colors, bcTO.power, bcTO.toughness, bcTO.cmc);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var _action = MessageBox.Show("Deseja inserir a carta na sua Wishlist?",
                "Atenção", MessageBoxButton.OKCancel);

            if (_action == MessageBoxResult.OK)
            {
                this.CardMV.Save("", "", "", "");

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Visualizacoes/Buscar.xaml?titulo=", UriKind.RelativeOrAbsolute));
        }
    }
}