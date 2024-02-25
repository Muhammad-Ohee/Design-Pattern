using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsApplication.ConcreteProducts
{
    public class Truck : ILogisticsApplication
    {
        public double GetDeliveryCost(int distance)
        {
            // Cost per mile for a truck might be $20.00
            return 20.00 * distance;
        }
    }
}
