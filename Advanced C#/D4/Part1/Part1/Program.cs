

using Microsoft.VisualBasic.FileIO;
using System.Threading.Channels;

namespace Part1
{
    public delegate void MySpecialDataType(int obj);

    
    public class Program
    {
        public static void Function1(int _value)
        {
            Console.WriteLine(_value);
        }

        public static void Main()
        {
            /*
                Anonymous Method 
                Lambda Expression
             */



            /*
            MySpecialDataType obj =
                new MySpecialDataType(Function1);
            */
            /*
            MySpecialDataType obj = Function1;
            */

            /*
            MySpecialDataType obj = delegate (int value)
            {
                Console.WriteLine(value);
            };
            */


            MySpecialDataType obj =
                i => Console.WriteLine(i);
         
            obj(20);


            Console.ReadKey();
        }
    }
}