using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ellipse : Circle
    {
        public int A { get; set; }

        public int B { get; set; }

        public Ellipse(double x, double y, int b, int a) : base(x, y, Math.Sqrt(a*b))
        {
            B = b;
            A = a;
        }

        public override double Area()
        {
            return Math.PI * A * B;
        }

        public override string ToString()
        {
            return $"(X:{base.X},Y:{base.Y}, a:{A}, b:{B}) area = {Area()}";
        }
    }
}
