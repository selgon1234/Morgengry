﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Merchandise
    {
        public string ItemID { get; set; }

        public Merchandise(string itemID)
        {
            ItemID = itemID;
        }
    }
}
