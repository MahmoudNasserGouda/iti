using System.Threading;

struct App
{
    static void CallMeWhenClock(object o)
    {
        Console.WriteLine("Clocking ...");
        GC.Collect();
    }
    
    static void Main()
    {
       
        Timer t = new Timer(CallMeWhenClock, 
            null, 0, 2000);
        
        Console.Read();

        //t.Dispose();
    }
}