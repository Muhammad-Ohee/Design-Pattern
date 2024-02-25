using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGatewayIntegration.ConcreteProducts
{
    public class BitCoin : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing bitcoin payment of amount: ${amount}");
            // Actual logic to process Bitcoin payment...
        }
    }
}
