using System;

namespace _NetFromCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello MVC 6 on .Net Framework Core!");
	    int x,y;
            x = int.Parse(Console.ReadLine());
	    y = int.Parse(Console.ReadLine());
	    Console.WriteLine(x+y);
        }
    }
}
