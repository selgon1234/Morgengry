using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class Amulet
    {
        string ItemID;
        string Design;
        enum Level { low, medium, high}
        Level Quality;

        public Amulet(string ItemID)
        {

        }
        public Amulet(string ItemID, string Design)
        {

        }
        public Amulet(string ItemID, string Design, string Quality)
        {
        }
        public override string ToString()
        {
            return "";
        }
    }
}
