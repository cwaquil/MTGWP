using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGWindowsPhone.Data
{
    public class BuscaCardTO
    {
        public BuscaCardTO(String name, String type, String subtype, List<String> colors, String power, String toughness, String cmc)
        {
            this.name = name;
            this.type = type;
            this.subtype = subtype;
            this.colors = colors;
            this.power = power;
            this.toughness = toughness;
            this.cmc = cmc;
        }


        public String name { get; set; }
        public String type { get; set; }
        public String subtype { get; set; }
        public List<String> colors { get; set; }
        public String power { get; set; }
        public String toughness { get; set; }
        public String cmc { get; set; }
    }
}
