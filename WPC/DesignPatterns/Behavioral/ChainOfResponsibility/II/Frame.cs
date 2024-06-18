using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Frame : Container
    {
        protected override void Click(bool handled)
        {
            Console.WriteLine($"Ramka {Name} zamigotała");
            base.Click(handled);
        }
    }
}
