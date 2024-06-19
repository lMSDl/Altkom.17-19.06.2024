using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using WPC.DesignPatterns.Creational.ObjectPool;

namespace WPC.DesignPatterns.Behavioral.Iterator
{
    internal class Client
    {
        public static void Execute()
        {
            List<string> list = new List<string>() { "1", "2", "3", "4", "5", "6" };

            var buffer = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine(buffer + list[i]);
                buffer = list[i];
            }

            var iterator = list.GetEnumerator();
            if (iterator.MoveNext())
            {
                buffer = iterator.Current;
                while (iterator.MoveNext())
                {
                    Console.WriteLine(buffer + iterator.Current);
                    buffer = iterator.Current;
                }
            }

            buffer = list[0];
            foreach (var item in list.Skip(1))
            {
                Console.WriteLine(buffer + item);
                buffer = item;
            }

            Console.WriteLine("-----");

            var bufferEnumerator = new Iterator.Buffer<string>(list).GetEnumerator();
            while (bufferEnumerator.MoveNext())
            {
                Console.WriteLine(bufferEnumerator.Current.Item1 + bufferEnumerator.Current.Item2);
            }

            foreach(var item in new Iterator.Buffer<string>(list))
            {
                Console.WriteLine(item.Item1 + item.Item2);
            }

            Console.WriteLine("____");

            foreach (var item in list.ToObservable()
                .Buffer(2, 1)
                .Where(x => x.Count() == 2)
                .ToEnumerable())
            {
                Console.WriteLine(item[0] + item[1]);
            }
        }
    }
}
