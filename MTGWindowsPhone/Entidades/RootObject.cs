using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGWindowsPhone.Entidades
{
    public class Format
    {
        public string name { get; set; }
        public string legality { get; set; }
    }

    public class RootObject
    {
        public int id { get; set; }
        public int relatedCardId { get; set; }
        public int setNumber { get; set; }
        public string name { get; set; }
        public string searchName { get; set; }
        public string description { get; set; }
        public string flavor { get; set; }
        public List<string> colors { get; set; }
        public string manaCost { get; set; }
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
        public List<object> rulings { get; set; }
        public List<Format> formats { get; set; }
        public string releasedAt { get; set; }
    }
}
