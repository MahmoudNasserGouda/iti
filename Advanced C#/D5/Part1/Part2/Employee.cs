using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"ID:{Id}, Name:{Name}";
        }
        public override bool Equals(object obj)
        {
            return
                this.Id == ((Employee)obj).Id
                && this.Name == ((Employee)obj).Name;
        }
        public override int GetHashCode()
        {
            return Id;
        }
    }
}
