using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Demo
{
    internal class Vehicle
    {
        public int ID;
        public string ModelNo;
        public string Engine;

        public Vehicle()
        {
            ID = 1;
            ModelNo = "111";
            Engine = "E1";
        }
        public Vehicle(string Engine , string ModelNo)
        {
            this.Engine = Engine;
            this.ModelNo = ModelNo;
        }
        public Vehicle(string Engine):this(Engine,"111")
        { }
        public void Move()
        {
            Console.WriteLine("Vehicle Move...");
        }


        public virtual void MoveLeft()
        {
            Console.WriteLine("Vehicle Move Left....");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle Stop...");
        }

        public virtual void MoveRight()
        {

            Console.WriteLine("V MoveRight....");
        }
        
    }
}
