using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Coins
    {
        public int Value { get; set; }
        public string Keychar { get; set; }

        public Coins(int value, string keychar)
        {
            Value = value;
            this.Keychar = keychar;
        }
    }
}
