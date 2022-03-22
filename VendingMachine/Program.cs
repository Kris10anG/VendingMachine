using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vendingmachine = new VendingMachine();
            while (true)
            {
                Console.WriteLine("Trykk y for å inspisere brusautomat, u for å vise brusliste");
                var command = Console.ReadLine();

                if (command == "y")
                {
                    vendingmachine.PrintFromVendingMachine();
                }

                if (command == "u")
                {
                    vendingmachine.PutInCoins(command);
                }

            }
        }
    }
}
