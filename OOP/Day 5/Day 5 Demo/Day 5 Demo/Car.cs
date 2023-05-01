using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Demo
{
    internal class Car :Vehicle
    {
        public string Color;

       
        public Car(string color):base("E1", "111")
        { }
        public Car():this("Black")
        { }
        public void Test()
        {
            base.ID = 22;
            
        }

        //Method Hiding
        public new void Move()
        {
            //base.Move(); //Calls parent function, Extened parent implementation
            Console.WriteLine("Car Move....");
            ///Logic 
        }
        // override ==> virtual by default
        public override void MoveLeft()
        {
            base.MoveLeft();
            Console.WriteLine("car Move Left ...");
        }
        // sealed ==> endpoint , remove virtual from override 
        public sealed override void Stop()
        {
            Console.WriteLine("Car Stopped...");
        }

        public new virtual void MoveRight()
        {
            Console.WriteLine("Car Move Right");
        }
    }
}
