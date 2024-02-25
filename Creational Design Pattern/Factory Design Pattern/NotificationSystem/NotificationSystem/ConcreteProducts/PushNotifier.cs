using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.ConcreteProducts
{
    public class PushNotifier : INotifier
    {
        // Concrete Products
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Push Notification: {message}");
            // Actual push sending logic goes here...
        }
    }
}
