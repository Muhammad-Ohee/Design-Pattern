﻿//Console.WriteLine("Hello, OS");

namespace DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "Angel",
                Department = "Software Engineer",
                employeeAddress = new Address() { EmployeeAddress = "Bangladesh" }
            };

            Employee employee2 = employee.GetClone();
            employee2.Name = "Angelina";
            employee2.employeeAddress.EmployeeAddress = "London";

            Console.WriteLine($"Employee Name: {employee.Name}" +
                              $"\nEmployee Department: {employee.Department}" +
                              $"\nEmployee Address: {employee.employeeAddress.EmployeeAddress}");

            Console.WriteLine();

            Console.WriteLine($"Employee Name: {employee2.Name}" +
                              $"\nEmployee Department: {employee2.Department}" +
                              $"\nEmployee Address: {employee2.employeeAddress.EmployeeAddress}");
        }
    }
}

