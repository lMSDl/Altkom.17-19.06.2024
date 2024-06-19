using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Command
{
    internal abstract class GardenCommand : ICommand
    {
        protected Garden Receiver { get; }
        protected string PlantName { get; }

        protected GardenCommand(Garden receiver, string plantName)
        {
            Receiver = receiver;
            PlantName = plantName;
        }

        public abstract bool Execute();
        public abstract void Reverse();
    }
}
