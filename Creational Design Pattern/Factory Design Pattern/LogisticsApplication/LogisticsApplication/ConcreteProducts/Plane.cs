using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsApplication.ConcreteProducts
{
    public class Plane : ILogisticsApplication
    {
        public double GetDeliveryCost(int distance)
        {
            // Cost per mile for a plane might be $40.00
            return 40.00 * distance;
        }
    }
}
