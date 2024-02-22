//Console.WriteLine("Hello, OS");

using Factory_Method_DP.ConcreteCreator;

namespace Factory_Method_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICreditCard creditCard = new MoneyBankFactory().CreateProduct();
            //ICreditCard creditCard = new PlatinumFactory().CreateProduct();
            ICreditCard creditCard = new TitaniumFactory().CreateProduct();

            if (creditCard != null)
            {
                Console.WriteLine($"Card Type: {creditCard.GetCardType()}");
                Console.WriteLine($"Card Limit: {creditCard.GetCardLimit()}");
                Console.WriteLine($"Card Annual Charge: {creditCard.GetAnnualCharge()}");
            }
            else
            {
                Console.WriteLine("Invalid Card");
            }
        }
    }
}