using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Flyweight
{
    internal class FlyweightFactory
    {
        static FlyweightFactory() { }
        public static FlyweightFactory Instance { get; } = new FlyweightFactory();

        private FlyweightFactory() { }

        private Dictionary<string, ProductFlyweight> _flyweights = new Dictionary<string, ProductFlyweight>();

        public void Initialize(params ProductFlyweight[] products)
        {
            foreach (var item in products)
            {
                _flyweights[GetKey(item)] =  item;
            }
        }

        private string GetKey(ProductFlyweight productFlyweight)
        {
            return string.Join("_", typeof(ProductFlyweight).GetProperties().Where(x => x.CanRead && x.CanWrite)
                .OrderBy(x => x.Name).Select(x => x.GetValue(productFlyweight)));
        }

        public ProductFlyweight GetFlyweight(ProductFlyweight productFlyweight)
        {
            var key = GetKey(productFlyweight);

            if(_flyweights.TryGetValue(key, out var flyweight))
            {
                Console.WriteLine($"Pobieramy stan ze słownika {key}");
                return flyweight;
            }

            Console.WriteLine($"Dodajemy stan do słownika: {key}");
            _flyweights[key] = productFlyweight;

            return productFlyweight;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Fabryka posiada {_flyweights.Count} stanów:");

            foreach (var item in _flyweights)
            {
                stringBuilder.AppendLine(item.Key);
            }

            return stringBuilder.ToString();
        }
    }
}
