using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticsApplication.ConcreteProducts;

namespace LogisticsApplication.ConcreteCreator
{
    public class TruckFactory : LogisticsAbstract
    {
        public override ILogisticsApplication CreateTransportObject()
        {
            return new Truck();
        }
    }
}
