using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle : Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public Rectangle(double x, double y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"(X:{base.X},Y:{base.Y}) Width = {Width}, Height = {Height}";
        }
    }
}
