using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Employee
    {
        public int ID { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(new Employee() { ID = 1 }, new Employee() { ID = 2 });
            hashtable.Add(new Employee() { ID = 1 }, new Employee() { ID = 2 });

            Console.ReadKey();
        }
    }
}
