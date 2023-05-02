using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Demo
{
    internal class Cat : IMovable
    {
        public void MoveBack()
        {
            Console.WriteLine("Cat MoveBack");

        }

        public void MoveFor()
        {
            Console.WriteLine("Cat MoveFor");
        }

        public void MoveLeft()
        {
            throw new NotImplementedException();
        }

        public void MoveRight()
        {
            throw new NotImplementedException();
        }
    }
}
