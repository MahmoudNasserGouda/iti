using ConsoleApp1;
internal class Program
{
    private static void Main(string[] args)
    {
        Employee e1 = new Employee("Ahmed", "45 St", "123456789", 50000, "junior");
        Employee e2 = new Employee("Mahmoud", "17 St", "987654321", 60000, "senior");

        Employee.DisplayCount();

        e1.Display();
        e2.Display();

        Console.ReadLine();
    }
}