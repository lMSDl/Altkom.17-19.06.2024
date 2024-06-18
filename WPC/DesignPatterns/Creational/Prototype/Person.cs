using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPC.DesignPatterns.Creational.Prototype
{
    internal class Person : ICloneable
    {
        public Person Parent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = (Address)Address.Clone();

            return clone;
        }

        public object DeepClone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = (Address)Address.Clone();
            clone.Parent = (Person)Parent?.Clone();

            return clone;
        }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
