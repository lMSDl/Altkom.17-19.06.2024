using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.FactoryMethod
{
    internal class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var action = "Down";
            var floor = 5;

            elevator.Execute(action, floor);

            action = "Up";
            floor = 5;

            elevator.Execute(action, floor);


            action = "GoTo";
            floor = 5;

            elevator.Execute(action, floor);

        }
    }
}
