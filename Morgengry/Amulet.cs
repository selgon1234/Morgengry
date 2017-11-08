using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Amulet : Merchandise
    {
        public string Design;
        public enum Level { low, medium, high}
        public Level Quality;

        public Amulet(string itemID)
        {
            ItemId = itemID;
            Quality = Level.medium;
        }
        public Amulet(string itemID, Level quality)
        {
            ItemId = itemID;
            Quality = quality;
        }
        public Amulet(string itemID, Level quality, string design)
        {
            ItemId = itemID;
            Design = design;
            Quality = quality;
        }
        public override string ToString()
        {
            return "ItemId: " + ItemId + "," + " " + "Quality: " + Quality + "," + " " + "Design: " + Design;
        }
    }
}
