using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    internal class VehicleBuilderFacade : BaseBuilder
    {
        public VehicleBuilderFacade()
        {
        }

        public VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Parts => new VehicleBuilder(Vehicle);
        public VehicleMetadataBuilder Info => new VehicleMetadataBuilder(Vehicle);
    }
}
