using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class Client
    {
        public static void Execute()
        {
            var handler4 = new DiscountHandler("Kierownik sklepu", 1000, 7500);
            var handler3 = new DiscountHandler("Kierownik sali", 500, 7500, handler4);
            //var handler2 = new DiscountHandler("Kierownik kas", 500, 10000, handler3);
            var handler1 = new DiscountHandler("Kasjer", 100, 10000, handler3);

            var result = handler1.Discount(500, 15000);
            if (!result)
                Console.WriteLine("Nie otrzymaliśmy rabatu");

            result = handler3.Discount(500, 15000);
            if (!result)
                Console.WriteLine("Nie otrzymaliśmy rabatu");
        }
    }
}
