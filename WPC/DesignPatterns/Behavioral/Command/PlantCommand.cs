using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Command
{
    internal class PlantCommand : GardenCommand
    {
        public PlantCommand(Garden receiver, string plantName) : base(receiver, plantName)
        {
        }

        public override bool Execute()
        {
            return Receiver.Add(PlantName);
        }

        public override void Reverse()
        {
            Receiver.Remove(PlantName);
        }
    }
}
