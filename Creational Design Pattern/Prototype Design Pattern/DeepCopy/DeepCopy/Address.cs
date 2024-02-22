using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    public class Address
    {
        public string EmployeeAddress { get; set; }

        public Address GetClone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
