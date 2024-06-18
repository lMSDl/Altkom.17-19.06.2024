using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Facade.I
{
    internal class SerializeFacade
    {
        static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            DateFormatString = "yy MM d"
        };

        public static string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Settings);
        }
    }
}
