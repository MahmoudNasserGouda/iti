using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Employee
    {
        public int ID;
        public void Display()
        {
            Console.WriteLine($"ID = {ID}");
        }
        ~Employee()
        {
            Console.WriteLine("Dying ..");
        }
    }
}
