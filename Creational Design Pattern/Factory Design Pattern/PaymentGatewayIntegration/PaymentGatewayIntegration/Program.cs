//Console.WriteLine("Hello, OS");

using PaymentGatewayIntegration.ConcreteCreator;

namespace PaymentGatewayIntegration
{
    // Client Code
    public class ECommercePlatform
    {
        public void Checkout(PaymentGatewayAbstract paymentGatewayAbstract, decimal amount)
        {
            IPaymentGateway iPaymentGateway = paymentGatewayAbstract.CreatePaymentGateway();
            iPaymentGateway.ProcessPayment(amount);
        }
    }

    // Testing the Factory Method Design Pattern
    class Program
    {
        static void Main(string[] args)
        {
            var platform = new ECommercePlatform();
            platform.Checkout(new CreditCardFactory(), 100.40M);
            platform.Checkout(new PayPalFactory(), 200.40M);
            platform.Checkout(new BitCoinFactory(), 400.40M);
        }
    }
}

