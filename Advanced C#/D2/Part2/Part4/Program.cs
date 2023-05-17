
using Part4;

public class Program
{
    private static Trainee obj = null;
    static void Test()
    {
        obj = new Trainee();
        Trainee T = new Trainee();
        Trainee T2 = new Trainee();
       
    }

    public static void GCIsWorking(int g)
    {
        Console.WriteLine(g);
    }
    public static void CallMe(object o)
    {
        Console.WriteLine("Firsing ..");
        GC.Collect();
    }
    static void Main()
    {


        GCNotifications.GCDone += GCIsWorking;
        //Test();

        Timer t = new Timer
            (CallMe, null, 0, 2000);

        Console.Read(); 
    }
}