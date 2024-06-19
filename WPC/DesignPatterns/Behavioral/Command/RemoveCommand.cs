using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Command
{
    internal class RemoveCommand : GardenCommand
    {
        public RemoveCommand(Garden receiver, string plantName) : base(receiver, plantName)
        {
        }

        public override bool Execute()
        {
            return Receiver.Remove(PlantName);
        }

        public override void Reverse()
        {
            Receiver.Add(PlantName);
        }
    }
}
