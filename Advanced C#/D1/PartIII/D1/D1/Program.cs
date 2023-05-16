

using D1;

public class Program
{
    public static int Main()
    {
        /*
        Calc c = new Calc();
        c.ShowMenu();
        int option  = c.GetUserOption();
        c.ProcessUserOption(option);
        */

        Employee E = new Employee() { ID  = 1, Name= "Ahmed"};
        Console.WriteLine(E.ToString());

        Console.ReadLine();
        return 0;
    }
}