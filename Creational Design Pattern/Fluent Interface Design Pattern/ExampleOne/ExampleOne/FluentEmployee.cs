using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    public class FluentEmployee
    {
        private Employee _employee = new Employee();

        public FluentEmployee Name(string name)
        {
            _employee.FullName = name;
            return this;
        }

        public FluentEmployee Born(string sDateTime)
        {
            _employee.DateOfBirth = Convert.ToDateTime(sDateTime);
            return this;
        }

        public FluentEmployee Working(string works)
        {
            _employee.WorkingOn = works;
            return this;
        }

        public FluentEmployee Stay(string stay)
        {
            _employee.StaysAt = stay;
            return this;
        }

        public Employee Build()
        {
            return _employee;
        }
    }
}
