using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Prototype
{
    internal class Client
    {
        public static void Execute()
        {


            var p0 = new Person()
            {
                FirstName = "Ewa",
                LastName = "Ewowska",
                Age = 45,
                Address = new Address { City = "Warszawa", Street = "Krakowska" },
                Parent = new Person { FirstName = "Tadeusz", LastName = "Ewowski" }
            };

            var p1 = (Person)p0.Clone();
            p1.FirstName = "Monika";

            Console.WriteLine(p0);
            Console.WriteLine(p1);

            p1.Address.Street = "Wrocławska";
            Console.WriteLine(p0);
            Console.WriteLine(p1);

        }
    }
}
