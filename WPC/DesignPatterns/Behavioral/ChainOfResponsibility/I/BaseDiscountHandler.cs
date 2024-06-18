using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class BaseDiscountHandler : IDiscountHandler
    {
        private readonly IDiscountHandler? _next;

        public BaseDiscountHandler() { }
        public BaseDiscountHandler(IDiscountHandler? next)
        {
            _next = next;
        }

        public virtual bool Discount(float value, float price)
        {
            return _next?.Discount(value, price) ?? false;
        }
    }
}
