using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_DP
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();

        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }       
}
