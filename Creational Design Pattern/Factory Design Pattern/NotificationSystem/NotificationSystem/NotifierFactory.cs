using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    //Creator (Abstract Class)
    public abstract class NotifierFactory
    {
        public abstract INotifier CreateNotifier();
    }
}
