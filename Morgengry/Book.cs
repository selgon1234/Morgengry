using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book
    {
        string ItemID;
        string Titel;
        double Price;
       
        public Book(string itemID)
        {
            ItemID = itemID;
        }
        public Book(string itemID, string titel)
        {
            ItemID = itemID;
            Titel = titel;
        }
        public Book(string itemID, string titel, double price)
        {
            ItemID = itemID;
            Titel = titel;
            Price = price;
        }
        public override string ToString()
        {
            return "ItemId: " + ItemID + "," + " " + "Title: " + Titel + "," + " " + "Price: " + Price;
        }
    }
}
