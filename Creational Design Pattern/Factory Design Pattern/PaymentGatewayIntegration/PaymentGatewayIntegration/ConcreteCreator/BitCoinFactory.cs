using PaymentGatewayIntegration.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGatewayIntegration.ConcreteCreator
{
    // Concrete Creators
    public class BitCoinFactory : PaymentGatewayAbstract
    {
        public override IPaymentGateway CreatePaymentGateway()
        {
            return new BitCoin();
        }
    }
}
