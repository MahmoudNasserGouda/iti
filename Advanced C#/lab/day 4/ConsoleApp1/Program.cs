using System;

namespace ConsoleApp1
{
    public delegate void MyDelegate(int num);

    class Program
    {
        static void Main(string[] args)
        {
            // Define the delegate
            MyDelegate myDelegate;

            // Method 1: Using a named method
            myDelegate = PrintNumber;

            // Method 2: Using an anonymous method
            myDelegate = delegate (int num) {
                Console.WriteLine(num);
            };

            // Method 3: Using a lambda expression
            myDelegate = (num) => Console.WriteLine(num);

            // Method 4: Using a method group conversion
            myDelegate = Console.WriteLine;

            // Call the delegate with an integer argument
            int num = 42;
            myDelegate(num);
        }

        static void PrintNumber(int num)
        {
            Console.WriteLine(num);
        }
    }
}