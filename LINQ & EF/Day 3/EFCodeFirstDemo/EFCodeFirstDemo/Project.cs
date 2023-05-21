using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    internal class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
