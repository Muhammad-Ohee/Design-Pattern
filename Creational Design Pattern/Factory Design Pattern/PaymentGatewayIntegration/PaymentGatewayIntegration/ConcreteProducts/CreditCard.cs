using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGatewayIntegration.ConcreteProducts
{
    public class CreditCard : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card payment of amount: ${amount}");
            // Actual logic to process credit card payment...
        }
    }
}
