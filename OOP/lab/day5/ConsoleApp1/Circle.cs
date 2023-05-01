using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double x, double y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public virtual double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Area(double pi)
        {
            return pi * Radius * Radius;
        }

        public override sealed void Display()
        {
            Console.WriteLine("Circle Display....");
        }

        public override string ToString()
        {
            return $"(X:{base.X},Y:{base.Y}, r:{Radius}) area = {Area()}";
        }
    }
}
