

using Part1;

public static class Program
{
    public static int Main()
    {

        FileSystemLogger logger = new FileSystemLogger();
        Employee E = new Employee(logger) { ID = 1, Name = "Ahmed" };
        E.Add();
        Console.WriteLine(E.ToString());

        IDbLogger dbLogger = new IDbLogger();
        Employee E2 = new Employee(dbLogger)
            { ID = 3, Name = "Hany" };
        E2.Add();


        return 0;
    }
}