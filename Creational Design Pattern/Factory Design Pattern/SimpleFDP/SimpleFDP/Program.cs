//Console.WriteLine("Hello, OS");

namespace SimpleFDP
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = CreditCardFactory.GetCreditCard("Titanium");

            if (creditCard != null)
            {
                Console.WriteLine($"Card Type: {creditCard.GetCardType()}");
                Console.WriteLine($"Card Limit: {creditCard.GetCreditLimit()}");
                Console.WriteLine($"Card Annual Charge: {creditCard.GetAnnualCharge()}");
            }
            else
            {
                Console.WriteLine("Invalid Card");
            }
        }
    }
}

