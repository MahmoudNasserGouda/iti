using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Demo
{
    internal class Buss :Vehicle
    {
        public override void MoveLeft()
        {
            Console.WriteLine("Buss Move Left...");
        }

        //Method Overloading
        /* 
         * 1- No. Param
         * 2- Data Type of Param
         * 3- Order of Param
         * */

        public int Sum()
        {
            return 1;
        }
        public int Sum(int x)
        {
            return x;
        }

        //Error, cannot overload return type 
        //public double Sum(int x)
        //{
        //    return x;
        //}
        public int Sum(int x, int y)
        {
            return x;
        }

        public int Sum(int x, double y)
        {
            return x;
        }
        public int Sum( double y, int x)
        {
            return x;
        }
    }
}
