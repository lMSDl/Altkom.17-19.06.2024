using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Flyweight
{
    internal class ProductFlyweight : ICloneable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public string Manufacturer { get; set; }
        public byte[] Logo { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void ShowShortInfo(Product product)
        {
            Console.WriteLine($"{Name} ({product.ExpirationDate.ToShortDateString()})");
        }
    }
}
