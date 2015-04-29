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
            ObservableCollection<CardModel> _cards = new ObservableCollection<CardModel>();

            _cards.Add(GetCard("XPTO", "A", "V", "B"));
            _cards.Add(GetCard("DGS", "D", "G", "C"));
            _cards.Add(GetCard("FFG", "F", "S", "B"));
            _cards.Add(GetCard("LKG", "Q", "F", "D"));
            _cards.Add(GetCard("YJS", "G", "O", "D"));

            Wishlist = _cards;
        }

        public CardModel GetCard(string name, string type, string subtype, string color)
        {
            CardModel _card = new CardModel()
            {
                Name = name,
                Type = type,
                Subtype = subtype,
                Color = color
            };

            return _card;
        }
        public void Save(string name, string type, string subtype, string color)
        {
            ObservableCollection<CardModel> _cards = new ObservableCollection<CardModel>();

            CardModel _card = new CardModel()
            {
                Name = name,
                Type = type,
                Subtype = subtype,
                Color = color
            };
           
            _cards.Add(_card);
            Wishlist = _cards;

            SaveIsolated();
        }

        public void Remove(string key)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains(key))
            {
                IsolatedStorageSettings.ApplicationSettings.Remove(key);
            }

            IsolatedStorageSettings.ApplicationSettings.Save();

            ObservableCollection<CardModel> _cards = new ObservableCollection<CardModel>();

            foreach (CardModel _card in Wishlist)
            {
                if(_card.Name != key)
                {
                    _cards.Add(_card);
                }
            }

            Wishlist = _cards;
        }

        public void SaveIsolated()
        {
            IsolatedStorageSettings setting = IsolatedStorageSettings.ApplicationSettings;
            foreach (CardModel _card in Wishlist)
            {
                if (setting.Contains(_card.Name))
                    setting[_card.Name] = _card;
                else
                    setting.Add(_card.Name, _card);
            }
            setting.Save();
        }

        public void GetIsolated()
        {
            Wishlist = null;
            ObservableCollection<CardModel> _cards = new ObservableCollection<CardModel>();
            foreach (Object item in IsolatedStorageSettings.ApplicationSettings.Values)
            {
                _cards.Add((CardModel)item);
            }
            Wishlist = _cards;
        }            

    }
}
