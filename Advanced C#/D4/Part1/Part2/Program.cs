

namespace Part2
{
    
    public delegate void Fun(int obj);
    public class Program
    {
        public static void Function1(int x)
        {
            Console.WriteLine(x);
        }
        public static void Function2(int x)
        {
            Console.WriteLine(x);
        }
        public static void Main()
        {
            /*
                Invocation List 
            */
            Fun obj = Function1;
            obj += Function2;
            obj += delegate (int i)
            {
                Console.WriteLine(i+1);
            };
            obj += i => Console.Write(i + 3);
            //obj -= Function1;
            //obj -= Function2;
            //obj = null;
           
            obj(2000); 

            Console.ReadKey();
        }
    }
}