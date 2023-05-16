


namespace Part4
{
    public class Program
    {
        public static void LogGC(int g)
        {
            Console.WriteLine($"Collecting in Generation {g}");
        }
        public static void Main()
        {

            GCNotifications.GCDone += LogGC;
            GC.Collect();


            Console.ReadKey();
        }
    }
}