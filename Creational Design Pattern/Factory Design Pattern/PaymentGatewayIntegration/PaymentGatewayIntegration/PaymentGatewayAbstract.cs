using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGatewayIntegration
{
    // Creator (Abstract Class)
    public abstract class PaymentGatewayAbstract
    {
        public abstract IPaymentGateway CreatePaymentGateway();
    }
}
