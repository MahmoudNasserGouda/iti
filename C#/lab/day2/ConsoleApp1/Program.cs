using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        //Assignments
        //1.Program to add two matrix[2D Array] and put the result in a third one, then print the result.
        int[,] mat1 = { { 1, 2 }, { 3, 4 } };
        int[,] mat2 = { { 5, 6 }, { 7, 8 } };
        int[,] result = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = mat1[i, j] + mat2[i, j];
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }

        //2.Program to find Sum & Average of 2D Array.
        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int sum = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
        }

        double avg = (double)sum / (arr.GetLength(0) * arr.GetLength(1));

        //3.Program to Find the Frequency of Characters in a String
        string str1 = "Hello, World!";
        Dictionary<char, int> freq = new Dictionary<char, int>();

        foreach (char c in str1)
        {
            if (Char.IsLetter(c))
            {
                if (freq.ContainsKey(c))
                {
                    freq[c]++;
                }
                else
                {
                    freq.Add(c, 1);
                }
            }
        }

        //4.Program to Remove all Characters in a String Except Alphabet
        string str2 = "Hello, World! 12345";
        foreach (char c in str2)
        {
            if (!Char.IsLetter(c))
            {
                str2 = str2.Remove(str2.IndexOf(c), 1);
            }
        }
        Console.WriteLine(str2);

        //5.Write a function takes array as parameter, and returns the largest number.
        static int FindMax(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        //6.Program that takes an array of integers and pass that array to a function to print array values after multiplying them to 10.
        int[] arr1 = { 1, 2, 3, 4, 5 };
        MultiplyArray(arr1);

        static void MultiplyArray(int[] arr)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i] * 10;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //7.Make function that calculate the sum of numbers from 1 to n using recursion.
        static int Sum_1_to_n(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + Sum_1_to_n(n - 1);
            }
        }

        //8.Make recursion function that get the GCD for a number.
        static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }

        //9.Try Stack and Queue on any datatype other than Int.
        Stack<String> stack = new Stack<String>();
        Queue<String> queue = new Queue<String>();

        for (int i = 1; i <= 5; i++)
        {
            String s = "String" + i;
            stack.Push(s);
            queue.Enqueue(s);
        }

        Console.WriteLine("Stack:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

        Console.WriteLine("\nQueue:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

        //10.Try to implement--jagged array
        int[][] arr_jag = new int[3][];

        arr_jag[0] = new int[] { 1, 2, 3 };
        arr_jag[1] = new int[] { 4, 5 };
        arr_jag[2] = new int[] { 6 };

        for (int i = 0; i < arr_jag.Length; i++)
        {
            for (int j = 0; j < arr_jag[i].Length; j++)
            {
                Console.Write(arr_jag[i][j] + " ");
            }
            Console.WriteLine();
        }

    }

}