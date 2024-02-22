using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFDP
{
    public class Platinum : CreditCard
    {
        public string GetCardType()
        {
            return "Platinum Card";
        }

        public int GetCreditLimit()
        {
            return 20000;
        }

        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
