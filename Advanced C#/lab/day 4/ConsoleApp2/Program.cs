namespace ConsoleApp2
{
    public delegate bool WHEN(Employee employee);

    public class Program
    {

        public static List<Employee> Search(Employee[] employees, WHEN Filter)
        {
            List<Employee> results = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (Filter(employee))
                {
                    results.Add(employee);
                }
            }

            return results;
        }

        static void Main(string[] args)
        {
            Employee[] employees = new Employee[] {
                new Employee { ID = 1, Name = "Ahmed" },
                new Employee { ID = 2, Name = "Mahmoud" },
                new Employee { ID = 3, Name = "Mohamed" }
            };

            foreach (Employee employee in Search(employees, e => e.ID > 2))
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
            foreach (Employee employee in Search(employees, e => e.Name.Contains("e")))
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
            foreach (Employee employee in Search(employees, e => e.Name.StartsWith("M")))
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}");
            }
        }
    }
}
