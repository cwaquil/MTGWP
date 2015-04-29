using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace MTGWindowsPhone.Entidades
{
    public class Card
    {
        public string id { get; set; }
        public int relatedCardId { get; set; }
        public int setNumber { get; set; }
        public string name { get; set; }
        public string searchName { get; set; }
        public string description { get; set; }
        public string flavor { get; set; }
        public string colors { get; set; }
        public string manacost { get; set; }
        public int convertedManaCost { get; set; }
        public string cardSetName { get; set; }
        public string type { get; set; }
        public string subType { get; set; }
        public int power { get; set; }
        public int toughness { get; set; }
        public int loyalty { get; set; }
        public string rarity { get; set; }
        public string artist { get; set; }
        public string cardSetId { get; set; }
        public bool token { get; set; }
        public bool promo { get; set; }
        public Ruling[] rulings { get; set; }
        public Format[] formats { get; set; }
        public DateTime releasedAt { get; set; }
    }
}
