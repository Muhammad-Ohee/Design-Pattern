using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFDP
{
    public class Titanium : CreditCard
    {
        public string GetCardType()
        {
            return "Titanium Card";
        }

        public int GetCreditLimit()
        {
            return 40000;
        }

        public int GetAnnualCharge()
        {
            return 5000;
        }
    }
}
