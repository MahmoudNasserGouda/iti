using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shape
    {
        public double X {  get; set; }

        public double Y { get; set; }

        public Shape(double x, double y)
        {
            X = x;
            Y = y;
        }

        public virtual void Display()
        {
            Console.WriteLine("Shape Display....");
        }

        public override string ToString()
        {
            return $"(X:{X},Y:{Y})";
        }
    }
}
