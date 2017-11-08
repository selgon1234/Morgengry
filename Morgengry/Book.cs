using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book : Merchandise
    {
        public string Title;
        public double Price;

        public Book(string itemID)
        {
            ItemId = itemID;
        }
        public Book(string itemID, string titel)
        {
            ItemId = itemID;
            Title = titel;
        }
        public Book(string itemID, string titel, double price)
        {
            ItemId = itemID;
            Title = titel;
            Price = price;
        }
        public override string ToString()
        {
            return "ItemId: " + ItemId + "," + " " + "Title: " + Title + "," + " " + "Price: " + Price;
        }
    }
}
