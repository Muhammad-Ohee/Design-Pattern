//Console.WriteLine("Hello, OS");

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "Angelina",
                Department = "CSE"
            };

            Employee employee2 = employee.GetClone();

            employee2.Name = "Angel";

            Console.WriteLine($"Employee Name: {employee.Name}" +
                              $"\nEmployee Department: {employee.Department}");

            Console.WriteLine();

            Console.WriteLine($"Employee Name: {employee2.Name}" +
                              $"\nEmployee Department: {employee2.Department}");
        }
    }
}