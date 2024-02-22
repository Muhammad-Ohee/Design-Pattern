using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address employeeAddress { get; set; }

        public Employee GetClone()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            employee.employeeAddress = employeeAddress.GetClone();
            return employee;
        }
    }
}
