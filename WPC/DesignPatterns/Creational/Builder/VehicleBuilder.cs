using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    internal class VehicleBuilder
    {
        private Vehicle Vehicle { get; } = new Vehicle();

        public VehicleBuilder SetWeels(int wheels)
        {
            Vehicle.Wheels = wheels;
            return this;
        }
        public VehicleBuilder SetDoors(int doors)
        {
            Vehicle.Doors = doors;
            return this;
        }
        public VehicleBuilder SetSeats(int seats)
        {
            Vehicle.Seats = seats;
            return this;
        }
        public VehicleBuilder SetEngine(int? power)
        {
            Vehicle.EnginePower = power;
            return this;
        }
        public VehicleBuilder SetTrunk(int capacity)
        {
            Vehicle.TrunkCapacity = capacity;
            return this;
        }

        public Vehicle Build()
        {
            return Vehicle;
        }
    }
}
