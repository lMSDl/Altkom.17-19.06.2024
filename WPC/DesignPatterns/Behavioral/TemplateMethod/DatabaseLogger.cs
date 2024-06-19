using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseLogger : Logger<DbLog, DatabaseService>
    {
        protected override void Save(DbLog item, DatabaseService service)
        {
            service.Insert(item);
        }

        protected override DbLog CreateItem(string message)
        {
            Console.WriteLine("Serializing message");
            return new DbLog { DateTime = DateTime.Now, Message = message };
        }

        protected override string PrepareMessage(string message)
        {
            return message;
        }

        protected override DatabaseService GetService()
        {
            return new DatabaseService();
        }
    }
}
