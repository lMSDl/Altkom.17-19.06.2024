using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.ObjectPool
{
    internal class Item
    {
        public bool IsVisible { get; set; }

        public byte[] Content { get; } = new byte[10240];
    }
}
