using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Demo
{
    public class Person
    {
        private int ID;  // class scope
        public string Name; //Solution Scope 
        protected int Age; // Childern Scope in the solution 
        internal string Address; // Project Scope 
        protected internal string Gender; // Project Scope + Any child in the solution 


        public void Test()
        {
            Console.WriteLine("Inside Parent fun.");
        }
    }
}
