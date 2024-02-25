using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.ConcreteProducts
{
    public class EmailNotifier : INotifier
    {
        // Concrete Products
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
            // Actual email sending logic goes here...
        }
    }
}
