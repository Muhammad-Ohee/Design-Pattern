using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Method_DP.Concrete_Products;

namespace Factory_Method_DP.ConcreteCreator
{
    class MoneyBankFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBank();
            return product;
        }
    }
}
