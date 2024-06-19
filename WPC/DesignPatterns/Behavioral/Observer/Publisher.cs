using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Observer
{
    internal class Publisher : IObservable<int>, IDisposable
    {
        private List<IObserver<int>> _observers = new();
        public IDisposable Subscribe(IObserver<int> observer)
        {
            Console.WriteLine($"{observer.GetType().Name} podłączył się");
            _observers.Add(observer);

            return new Subscription(() => _observers.Remove(observer));
        }

        public int Index { get; set; }

        public async Task Work()
        {
            for (int i = 0; i < 15; i++)
            {
                await Task.Delay(1000);
                var second = DateTime.Now.Second;
                if (second % 3 == 0)
                {
                    Index = second;
                    Notify();
                }
            }
        }

        private void Notify()
        {
            Console.WriteLine($"Powiadomienie: {Index}");
            if(Index == 0)
            {
                foreach (var item in _observers.ToList())
                {
                    item.OnError(new IndexOutOfRangeException(Index.ToString()));
                }
            }
            else
            {
                foreach (var item in _observers.ToList())
                {
                    //item.OnNext(Index);
                    Task.Run(() => item.OnNext(Index));
                }
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Zamknięcie źródła");
            foreach (var item in _observers.ToList())
            {
                item.OnCompleted();
            }
        }
    }
}
