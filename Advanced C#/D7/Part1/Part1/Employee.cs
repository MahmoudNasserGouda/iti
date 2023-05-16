
using System;
namespace Part1
{
    public delegate void EmployeeHandler (Employee employee);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public event EmployeeHandler EmployeeAdded;
        public override string ToString()
        {
            return $"ID:{ID}, Name:{Name}";
        }
        public void Add()
        {
            Console.WriteLine("Adding ...");
            if(EmployeeAdded != null) 
            {
                EmployeeAdded(this);
            }
        }
    }
}
