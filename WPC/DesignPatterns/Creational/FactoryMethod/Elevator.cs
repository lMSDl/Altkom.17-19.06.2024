using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.FactoryMethod
{
    internal class Elevator
    {
        private readonly Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>(); 

        public void Execute(IElevatorOperation operation, int floor)
        {
            operation?.Operate(floor);
        }

        public void Execute(string operation, int floor)
        {
            Execute(CreateElevatorOperation(operation), floor);
        }

        private IElevatorOperation CreateElevatorOperation(string action)
        {
            if (!_operations.TryGetValue(action, out var elevatorOperation))
            {
                switch (nameof(Elevator) + action)
                {
                    case nameof(ElevatorDown):
                        elevatorOperation = new ElevatorDown();
                        break;
                    case nameof(ElevatorUp):
                        elevatorOperation = new ElevatorUp();
                        break;
                    case nameof(ElevatorGoTo):
                        elevatorOperation = new ElevatorGoTo();
                        break;
                }
                _operations[action] = elevatorOperation;
            }

            return elevatorOperation;
        }
    }
}
