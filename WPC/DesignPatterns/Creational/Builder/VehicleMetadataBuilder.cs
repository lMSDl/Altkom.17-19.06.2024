using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    internal class VehicleMetadataBuilder : VehicleBuilderFacade
    {
        public VehicleMetadataBuilder()
        {
        }

        public VehicleMetadataBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleMetadataBuilder SetManufacturer(string value)
        {
            Vehicle.Manufacturer = value;
            return this;
        }
        public VehicleMetadataBuilder SetYear(int value)
        {
            Vehicle.Year = value;
            return this;
        }
    }
}
