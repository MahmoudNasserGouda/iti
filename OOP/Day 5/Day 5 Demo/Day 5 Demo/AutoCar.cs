using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Demo
{
    //Multilevel inheritance
    internal class AutoCar :Car
    {
        public override void MoveLeft()
        {
            base.MoveLeft();
            Console.WriteLine("Auto Car Move Left...");
        }
        public override void MoveRight()
        {
            Console.WriteLine("Auto Car Right");
        }
    }
}
