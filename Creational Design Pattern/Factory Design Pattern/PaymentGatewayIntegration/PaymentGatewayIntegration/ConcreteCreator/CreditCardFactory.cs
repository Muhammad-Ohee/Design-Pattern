using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentGatewayIntegration.ConcreteProducts;

namespace PaymentGatewayIntegration.ConcreteCreator
{
    // Concrete Creators
    public class CreditCardFactory : PaymentGatewayAbstract
    {
        public override IPaymentGateway CreatePaymentGateway()
        {
            return new CreditCard();
        }
    }
}
