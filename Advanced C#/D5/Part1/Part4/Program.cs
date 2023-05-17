

using Part4;

public class Employee
{
    public int Id { get; set; }
}
public static class Program
{
    public static int Main()
    {

        ITIStack<int> s = new ITIStack<int>(10);
        s.Push(10);
        s.Push(13);
        s.Push(5);


        Console.WriteLine(s.Pop()); 
        Console.WriteLine(s.Pop());

        int Number = s.Pop();


        ITIStack<Employee> sOfEmployees = new ITIStack<Employee>(30);
        sOfEmployees.Push(new Employee() { Id=10});
        sOfEmployees.Push(new Employee() { Id=20});


        Employee E =  sOfEmployees.Pop();




        Console.ReadKey();

        return 0;
    }
}