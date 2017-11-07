using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Amulet : Merchandise
    {
        string Design;
        public enum Level { low, medium, high}
        Level Quality;

        public Amulet(string itemID) : base(itemID)
        {
            Quality = Level.medium;
        }
        public Amulet(string itemID, Level quality) : base(itemID)
        {
            Quality = quality;
        }
        public Amulet(string itemID, Level quality, string design) : base(itemID)
        {
            Design = design;
            Quality = quality;
        }
        public override string ToString()
        {
            return "ItemId: " + ItemID + "," + " " + "Quality: " + Quality + "," + " " + "Design: " + Design;
        }
    }
}
