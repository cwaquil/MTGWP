using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace MTGWindowsPhone.Entidades
{
    public class Card
    {
        int id { get; set; }
        int relatedCardId { get; set; }
        int setNumber { get; set; }
        String name { get; set; }
        String searchName { get; set; }
        String description { get; set; }
        String flavor { get; set; }
        String[] colors { get; set; }
        String manacost { get; set; }
        int convertedManaCost { get; set; }
        String cardSetName { get; set; }
        String type { get; set; }
        String subType { get; set; }
        int power { get; set; }
        int toughness { get; set; }
        int loyalty { get; set; }
        String rarity { get; set; }
        String artist { get; set; }
        String cardSetId { get; set; }
        bool token { get; set; }
        bool promo { get; set; }
        Ruling[] rulings { get; set; }
        Format[] formats { get; set; }
        DateTime releasedAt { get; set; }
    }
}
