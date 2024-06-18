using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Facade.III
{
    internal interface IJsonConverter
    {
        string ToJson<T>(T obj);
    }
}
