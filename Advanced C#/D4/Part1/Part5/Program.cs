

using System;

namespace Part5
{
    public delegate bool WHEN(string name);
    public class Program
    {
        public static string[] Search(string[] Source, WHEN Filter)
        {
            int index = 0;
            string[] result = new string[Source.Length];
            for (int i = 0; i < Source.Length; i++)
            {
                if (Filter(Source[i]) == true)
                {
                    result[index] = Source[i];
                    index++;
                }
            }
            return result;
        }


       
       


        public static void Main()
        {

            string[] names
                 = new string[]
                 {
                     "Ahmed", "Sayed", 
                     "Gamal", "Saja", "Assmaa"
                 };

            string[] result = Search(names, i => i[1]=='h');
            foreach (string name in result)
                Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}