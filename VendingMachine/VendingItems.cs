using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingItems
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Keypress { get; set; }
        public int  Quantity { get; set; }

        public VendingItems(string name, int price, string keypress, int quantity)
        {
            Name = name;
            Price = price;
            Keypress = keypress;
            Quantity = quantity;
        }
      
    }
}
