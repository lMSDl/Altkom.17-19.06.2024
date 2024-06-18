using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Decorator
{
    internal class Client
    {
        public static void Execute()
        {
            while (true)
            {
                var text = Console.ReadLine();

                INotification notification = new SystemNotification();

                if (DateTime.Now.Second % 2 == 0)
                    notification = new EmailNotification(notification);

                if (DateTime.Now.Second % 3 == 0)
                    notification = new SmsNotification(notification);

                notification.Send(text);
            }
        }
    }
}
