using MTGWindowsPhone.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MTGWindowsPhone.ModelView
{
    class CardModelView
    {
        public ObservableCollection<CardModel> Wishlist { get; set; }

        public void GetWishlist()
        {
            ObservableCollection<CardModel> _cards =
                new ObservableCollection<CardModel>();

            _cards.Add(GetCard("XPTO"));
            _cards.Add(GetCard("DGS"));
            _cards.Add(GetCard("FFG"));
            _cards.Add(GetCard("LKG"));
            _cards.Add(GetCard("YJS"));

            Wishlist = _cards;
        }

        public CardModel GetCard(string name)
        {
            CardModel _card = new CardModel()
            {
                Name = name,
                Type = "B",
                Subtype = "A",
                Color = "Branca"
            };
            return _card;
        }

        public void Save()
        {
            IsolatedStorageSettings setting = IsolatedStorageSettings.ApplicationSettings;
            foreach (CardModel _card in Wishlist)
            {
                setting.Add(_card.Name, _card.Color);
            }
            setting.Save();
            MessageBox.Show("Carta registrada!");
        }
    }
}
