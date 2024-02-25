using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.ConcreteProducts
{
    public class SMSNotifier : INotifier
    {
        // Concrete Products
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
            // Actual SMS sending logic goes here...
        }
    }
}
