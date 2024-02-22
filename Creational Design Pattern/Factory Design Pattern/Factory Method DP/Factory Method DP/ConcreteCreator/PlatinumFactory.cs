using Factory_Method_DP.Concrete_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_DP.ConcreteCreator
{
    class PlatinumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}
