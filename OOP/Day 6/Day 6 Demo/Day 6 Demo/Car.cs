using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Demo
{
    internal class Car :Vehicle
    {
        public string Color;
        public string Engine;
        //public Car(string Color)
        //{
        //    this.Color = Color;
        //}
        //public Car():this("Black")
        //{

        //}

        // Forcing Override
        public override void Move()
        {
            
            Console.WriteLine("Car Move...");
        }

        //Optional
        //public override void Stop()
        //{
           
        //}


        public override string ToString()
        {
            return $"Car {Color}";
        }
        public override bool Equals(object obj)
        {
            Car TempC = (Car)obj;
            return this.Color == TempC.Color;
        }
    }
}
