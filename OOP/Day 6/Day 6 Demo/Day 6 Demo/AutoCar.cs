using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Demo
{
    internal class AutoCar :Vehicle,  IMovable
    {
        public override void Move()
        {
            Console.WriteLine("Move Car");
        }

        //public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void MoveBack()
        {
            Console.WriteLine("Car MoveBack");
        }

        public void MoveFor()
        {
            Console.WriteLine("Car MoveFor");
        }

        public void MoveLeft()
        {
            Console.WriteLine("Car Left");

        }

        public void MoveRight()
        {
            Console.WriteLine("Car Right");
        }
    }
}
