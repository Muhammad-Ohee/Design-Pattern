//Console.WriteLine("Hello, OS");

using NotificationSystem.ConcreteCreator;

namespace NotificationSystem
{
    public class NotificationSystem
    {
        // Client Code
        public void NotifyUser(NotifierFactory notifierFactory, string message)
        {
            INotifier iNotifier = notifierFactory.CreateNotifier();
            iNotifier.SendNotification(message);
        }
    }

    // Testing the Factory Method Design Pattern
    class Program
    {
        static void Main(string[] args)
        {
            // For a user who prefers email notifications:
            var notificationSystem = new NotificationSystem();
            notificationSystem.NotifyUser(new EmailFactory(), "This is an email notification!");

            // For a user who prefers SMS notifications:
            notificationSystem = new NotificationSystem();
            notificationSystem.NotifyUser(new SMSFactory(), "This is an SMS notification!");

            // For a user who prefers push notifications:
            notificationSystem = new NotificationSystem();
            notificationSystem.NotifyUser(new PushFactory(), "This is an Push notification!");
        }
    }
}

