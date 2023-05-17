

using Microsoft.VisualBasic.FileIO;
using Part2;

public class Program
{
    static void Test()
    {
        Employee E = new Employee() { ID  = 10};
        Employee E2 = new Employee() { ID  = 40};

        Console.WriteLine(E.ID);
        Console.WriteLine(E2.ID);

        GC.Collect();

    }
    static void Main()
    {
        Test();

        Employee E =new Employee ();
        Employee C = new Employee();
        /*
        Employee E ;
        E.ID = 10;
        E.ID = 30;
        E.Display();
        Employee E2 = E;
        E2.Display();
        */


        
















    }
}