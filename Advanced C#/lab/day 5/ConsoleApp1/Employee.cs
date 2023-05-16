using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee))
            {
                return false;
            }
            return Id == ((Employee)obj).Id;
        }
    }
}
