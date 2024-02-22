//Console.WriteLine("Hello, OS");

namespace ExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee fluentEmployee = new FluentEmployee()
                .Name("Angle")
                .Born("04.11.1999")
                .Working("Software Engineer")
                .Stay("Bangladesh");
            Employee employee = fluentEmployee.Build();

            //Employee employee = new Employee();
            //employee = fluentEmployee.Name("Angelina").Born("04/11/1999").Working("Engineer").Stay("Bangladesh").Build();

            Console.WriteLine($"Employee Name: {employee.FullName}" +
                              $"\nEmployee Date of Birth: {employee.DateOfBirth.ToShortDateString()}" +
                              $"\nEmployee Designation: {employee.WorkingOn}" +
                              $"\nEmployee Location: {employee.StaysAt}");

            Console.WriteLine();
            Console.WriteLine("Fluent Interface Design Pattern in LINQ");
            var traslation = new Dictionary<string, string>
            {
                { "alpha", "heart" },
                { "beta", "blood" },
                { "gamma", "vein" },
                { "sigma", "brain" }
            };

            IEnumerable<string> query = traslation
                .Where(t => t.Key.Contains("a"))
                .OrderBy(t => t.Value.Length)
                .Select(t => t.Value.ToUpper());

            Console.WriteLine("Query Result:");
            foreach (var value in query)
            {
                Console.WriteLine(value);
            }
        }
    }
}

