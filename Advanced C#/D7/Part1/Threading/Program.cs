


using System.Diagnostics;

namespace Threading
{
    public static class Program
    {
        public static string state = "";
        public static object stateLock = new object();

        public static void ChangeState(string NewState, string FunctionName)
        {
            Console.WriteLine($"{FunctionName}, Is Writing");
            lock (stateLock)
            {
                foreach (char ch in NewState)
                {
                    Thread.Sleep(1000);
                    state += ch;
                }
            }
        }
        public static void Fun1()
        {
            Console.WriteLine("Start Fun1");
            ChangeState("Assiut", "Fun1");
            Console.WriteLine("End Fun1");

        }
        public static void Fun2()
        {
            Console.WriteLine("Start Fun2");
            ChangeState("Aswan", "Fun2");
            Console.WriteLine("End Fun2");
        }
        public static void Fun3()
        {
            Console.WriteLine("Start Fun3");
            ChangeState("Minia", "Fun3");
            Console.WriteLine("End Fun3");

        }
        public static int Main()
        {
            Console.WriteLine("Start Of Program");
            /*
            Stopwatch sw = Stopwatch.StartNew();
            
            Thread T1 = new Thread(Fun1);
            Thread T2 = new Thread(Fun2);
            Thread T3 = new Thread(Fun3);

            T1.Start();
            T2.Start();
            T3.Start();
            sw.Stop();
            T1.Join();
            T2.Join();
            T3.Join();
            Console.WriteLine($"State: {state}");
            Console.WriteLine($"Time: {sw.Elapsed.TotalSeconds}");
            Console.WriteLine("End Of Program");
           
            */
            Console.ReadKey();



            return 0;
        }
    }
}