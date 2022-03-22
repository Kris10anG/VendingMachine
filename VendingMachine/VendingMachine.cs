using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {
        public List<VendingItems> VendingItemsList { get; set; }
        private int Wallet = 0;
        public List<Coins> CoinsList { get; set; }

        public VendingMachine()
        {
            VendingItemsList = new List<VendingItems>
            {
                new VendingItems("Coca Cola", 20, "c", 5),
                new VendingItems("Pepsi Max", 10, "p", 5),
                new VendingItems("Solo Super", 15, "s", 5),
                new VendingItems("Redbull Regular", 25, "r", 1),
                new VendingItems("Burn Mango", 25, "b", 5),
                new VendingItems("Litago sjokolade", 15, "b", 0),
                new VendingItems("Freia Melkesjokolade", 30, "f", 2),
                new VendingItems("Maarud Potetgull classic salt", 20, "m", 1),
                new VendingItems("Kims Potetgull Paprika", 20, "k", 2),
            };
            CoinsList = new List<Coins>
            {
                new Coins(1, "1"),
                new Coins(5, "2"),
                new Coins(10, "3"),
                new Coins(20, "4"),
            };
        }


        public bool BuyFromVendingMachine(string keypress)
        {
            var vendingItems = VendingItemsList.FirstOrDefault(item => item.Keypress == keypress);
            if (Wallet >= vendingItems.Price)
            {
                Wallet -= vendingItems.Price;
                Console.WriteLine("Du har kjøpt: " + vendingItems.Name);
                if (Wallet > 0)
                {
                    Console.WriteLine("Du har: " + Wallet + "Kr igjen");
                }

                return true;
            }

            if (Wallet < vendingItems.Price)
            {
                var moremoney = Wallet - vendingItems.Price;
                Console.WriteLine("Du trenger: " + moremoney + "Kr for å kjøpe " + vendingItems.Name);
            }
            return false;
        }

        public void PrintFromVendingMachine()
        {
            foreach (var item in VendingItemsList)
            {
                Console.WriteLine("Navn: " + item.Name + " Pris: " + item.Price + " Tastetrykk: " + item.Keypress + " antall: " + item.Quantity);
            }
        }

        public void PutInCoins(string command)
        {
            var coins = CoinsList.FirstOrDefault(coin => coin.Keychar == command);
            Console.WriteLine("Du puttet på " + coins + "Kr");
        }
    }
}