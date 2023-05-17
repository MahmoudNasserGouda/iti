

using System;
using Part1;

public static class Program
{

    static void DisplayEmployee(Employee employee)
    {
        Console.WriteLine(employee.ToString());
    }
    static void Log(Employee employee)
    {
        Console.WriteLine($"Logging .. {employee.Name}");
    }
    public static int Main()
    {

        Employee E = new Employee() { ID = 1, Name = "Asmaa" };
        E.EmployeeAdded += Program.DisplayEmployee;
        E.EmployeeAdded += Program.Log;
        E.Add();

        Console.ReadKey(); 


        return 0;
    }
}