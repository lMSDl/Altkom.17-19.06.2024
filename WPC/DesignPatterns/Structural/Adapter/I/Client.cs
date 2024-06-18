using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Adapter.I
{
    internal class Client
    {
        public static void Execute()
        {
            ICircle circle = new Circle() { R = 5 };

            CheckR(circle);

            Square square = new Square() { A = 8 };
            CheckR(new SquareToCircleAdapter(square));
        }

        public static void CheckR(ICircle circle)
        {
            Console.WriteLine(circle.R <= 5);
        }


    }
}
