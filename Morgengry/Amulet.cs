using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Amulet
    {
        string ItemID;
        string Design;
        public enum Level { low, medium, high}
        Level Quality;

        public Amulet(string itemID)
        {
            ItemID = itemID;
        }
        public Amulet(string itemID, Level quality)
        {
            ItemID = itemID;
            Quality = quality;
        }
        public Amulet(string itemID, Level quality, string design)
        {
            ItemID = itemID;
            Design = design;
            Quality = quality;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
