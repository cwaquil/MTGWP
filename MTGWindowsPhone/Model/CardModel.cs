using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGWindowsPhone.Model
{
    using System.ComponentModel;
    /// <summary>
    /// Entidade de domínio
    /// </summary>
    public class CardModel : INotifyPropertyChanged
    {

        private string _id;
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                EventPropertyChanged("Id");
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                EventPropertyChanged("Name");
            }
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                EventPropertyChanged("Type");
            }
        }

        private string _subtype;
        public string Subtype
        {
            get { return _subtype; }
            set
            {
                _subtype = value;
                EventPropertyChanged("Subtype");
            }
        }

        private string _color;
        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
                EventPropertyChanged("Color");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void EventPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #region Metodos
        public CardModel getCard()
        {
            CardModel copia = (CardModel)this.MemberwiseClone();
            return copia;
        }
        #endregion
    }
}
