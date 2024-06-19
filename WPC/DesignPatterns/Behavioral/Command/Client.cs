using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Command
{
    internal class Client
    {
        public static void Execute()
        {
            var garden = new Garden(5);
            var command1 = new PlantCommand(garden, "drzewo");
            var command2 = new RemoveCommand(garden, "drzewo");
            var command3 = new PlantCommand(garden, "kwiaty");
            var command4 = new RemoveCommand(garden, "kwiaty");

            var plantTreeButton = new CommandInvoker(command1);
            var removeTreeButton = new CommandInvoker(command2);
            var plantFlowersButton = new CommandInvoker(command3);
            var removeFlowersButton = new CommandInvoker(command4);


            Console.WriteLine(garden);

            plantTreeButton.Invoke();
            plantTreeButton.Invoke();
            plantTreeButton.Invoke();

            Console.WriteLine(garden);

            plantFlowersButton.Invoke();
            plantFlowersButton.Invoke();
            plantFlowersButton.Invoke();

            Console.WriteLine(garden);

            removeTreeButton.Invoke();
            removeFlowersButton.Invoke();
            removeFlowersButton.Invoke();
            removeFlowersButton.Invoke();

            Console.WriteLine(garden);

            CommandInvoker.Undo();
            CommandInvoker.Undo();
            CommandInvoker.Undo();
            CommandInvoker.Undo();
            Console.WriteLine(garden);

        }
    }
}
