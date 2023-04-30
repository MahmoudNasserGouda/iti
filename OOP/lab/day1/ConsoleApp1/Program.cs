using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //6-Create at least 6 employees instances and display their values.(Use array)
        Employee[] employees = new Employee[6];

        employees[0] = new Employee(1, "Ahmed", 30, 5, 50000);
        employees[1] = new Employee(2, "Mahmoud", 25, 2, 40000);
        employees[2] = new Employee(3, "Mohamed", 35, 10, 70000);
        employees[3] = new Employee(4, "Ali", 28, 3, 45000);
        employees[4] = new Employee(5, "Mostafa", 32, 7, 60000);
        employees[5] = new Employee(6, "Said", 27, 1, 35000);

        foreach (Employee emp in employees)
        {
            emp.display();
            Console.WriteLine();
        }

        //-	Make Employee no.2 a copy of Employee no.1 
        //o Do you need to use copy constructor? Why?
        employees[1] = new Employee(employees[0]);

        //-	Make Employee no.3 references Employee no.4
        //o Do you need to use copy constructor? Why?
        employees[2] = employees[3];
    }
}
