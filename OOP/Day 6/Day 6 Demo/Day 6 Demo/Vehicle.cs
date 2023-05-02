using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Demo
{
    internal abstract class Vehicle
    {
        public string Motore;

        //abstract ==> virtual by default
        public abstract void Move();
        

        public virtual void Stop()
        {
            Console.WriteLine("V Stop..");
        }
        
    }
}
