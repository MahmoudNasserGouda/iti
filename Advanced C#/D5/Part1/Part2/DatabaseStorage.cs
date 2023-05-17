using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class DatabaseStorage
    {
        public Employee[] Employees { get; set; } 
        public DatabaseStorage()
        {
            Employees = new Employee[]
            {
                new Employee { Id=1, Name= "Ahmed"},
                new Employee { Id=1, Name= "Ahmed"},
                new Employee { Id=3, Name= "Mostafa"},
                new Employee { Id=4, Name= "Saja"},
                new Employee { Id=5, Name= "Fatma"},
                new Employee { Id=6, Name= "Ramy"},
            };
        }
    }
}
