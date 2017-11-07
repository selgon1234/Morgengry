using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book : Merchandise
    {
        public string Titel;
        public double Price;

        public Book(string itemID) : base(itemID)
        {
        }
        public Book(string itemID, string titel) : base(itemID)
        {
            Titel = titel;
        }
        public Book(string itemID, string titel, double price) : base(itemID)
        {
            Titel = titel;
            Price = price;
        }
        public override string ToString()
        {
            return "ItemId: " + ItemID + "," + " " + "Title: " + Titel + "," + " " + "Price: " + Price;
        }
    }
}
