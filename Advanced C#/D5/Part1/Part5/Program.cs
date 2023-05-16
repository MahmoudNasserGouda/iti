
using Part5;

public static class Program
{
    public static int Main()
    {
        DatabaseStorage db = new DatabaseStorage();
        EntityManager<Employee> emMgr = new EntityManager<Employee>(db);
        Employee E = new Employee() { ID = 1, Name = "Ahmed" };
        emMgr.Add(E);
        Employee E2 = new Employee() { ID = 2, Name = "Hany" };
        emMgr.Add(E2);
        foreach (Employee e in emMgr.GetAll())
            Console.WriteLine(e);

        Console.WriteLine();
        Console.WriteLine();

        EntityManager<Trainee> tnMgr = new EntityManager<Trainee>(db);
        Trainee T = new Trainee() { ID = 1, Name = "Saad" };
        Trainee T2 = new Trainee() { ID = 2, Name = "Safaa" };
        tnMgr.Add(T);
        tnMgr.Add(T2);
        foreach (Trainee t in tnMgr.GetAll())
            Console.WriteLine(t);

        Console.WriteLine();
        Console.WriteLine((tnMgr.Get(1)).ToString());



        return 0;
    }
}