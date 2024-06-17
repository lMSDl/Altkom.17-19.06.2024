using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    internal class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(4, 5, 4, 500, 100);
            Console.WriteLine(vehicle);

            var builder = new VehicleBuilder();
            builder.SetWeels(4);
            builder.SetDoors(4);
            builder.SetSeats(5);
            builder.SetTrunk(500);
            builder.SetEngine(100);

            vehicle = builder.Build();
            Console.WriteLine(vehicle);

            vehicle = new Vehicle { Doors = 4, Seats = 5, Wheels = 4, EnginePower = 100, TrunkCapacity = 500 };
            Console.WriteLine(vehicle);

            vehicle = new VehicleBuilder().SetWeels(4)
                                            .SetDoors(4)
                                            .SetSeats(5)
                                            .SetTrunk(500)
                                            .SetEngine(100)
                                            .Build();
            Console.WriteLine(vehicle);
        }
    }
}
