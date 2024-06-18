using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    internal abstract class BaseBuilder
    {
        protected Vehicle Vehicle { get; } = new Vehicle();
        public BaseBuilder()
        {
            Vehicle = new Vehicle();
        }

        public BaseBuilder(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)Vehicle.Clone();
        }
    }
}
