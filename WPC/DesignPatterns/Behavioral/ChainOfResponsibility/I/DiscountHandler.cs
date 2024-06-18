using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class DiscountHandler : BaseDiscountHandler
    {

        public string Name { get; }
        protected float MaxDiscount { get; }
        protected float MinPrice { get; }


        public DiscountHandler(string name, float maxDiscount, float minPrice) : this(name, maxDiscount, minPrice, null)
        {
        }

        public DiscountHandler(string name, float maxDiscount, float minPrice, IDiscountHandler? next) : base(next)
        {
            Name = name;
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }

        public override bool Discount(float value, float price)
        {
            if (value > MaxDiscount || price < MinPrice)
                return base.Discount(value, price);

            Console.WriteLine($"{Name} udzielił rabatu {value}");
            return true;
        }
    }
}
