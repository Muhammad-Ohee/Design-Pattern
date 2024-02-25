using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGatewayIntegration
{
    // Product (Interface)
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
