﻿using System;
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
        double price;
       
        public Book(string ItemID)
        {
        
        }
        public Book(string ItemID, string Titel)
        {

        }
        public Book(string ItemID, string Titel, double price)
        {
        }
        public override string ToString()
        {
            return "ItemId: 1," + " Title: ," + " " + "Price: 0";
        }
    }
}
