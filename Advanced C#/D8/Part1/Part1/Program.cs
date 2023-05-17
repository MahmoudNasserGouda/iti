
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace Part1
{
    public static class Program
    {
        public static void DisplayXs()
        {
            for(int i=0; i< 50; i++)
            {
                Console.WriteLine("X");
            }
            Thread.Sleep(2000);
        }
        public static void DisplayYs()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Y");
            }
            Thread.Sleep(2000);
        }
        public static int Main()
        {
            Stopwatch sw = Stopwatch.StartNew();

            Task<string> T1 = Task.Run(() =>
            {
                DisplayXs();
                return "T1 is Finished";
            });
            T1.ContinueWith((info)=>
            {
                Console.WriteLine(info.Result);
            });
            Task T2 = Task.Run(() =>
            {
                DisplayYs();
            });



            T1.Wait();
            T2.Wait();
           

            sw.Stop();

            Console.WriteLine($"Time: {sw.Elapsed.TotalSeconds}");

            Console.ReadKey(); 

            return 0;
        }
    }
}