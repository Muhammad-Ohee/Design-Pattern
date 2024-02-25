using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsApplication
{
    public abstract class LogisticsAbstract
    {
        public abstract ILogisticsApplication CreateTransportObject();
    }
}
