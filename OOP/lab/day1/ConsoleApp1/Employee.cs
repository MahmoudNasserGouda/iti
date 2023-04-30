using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Employee
    {
        //1-Create class Employee with 5 fields(ID, Name, Age, Experience, Salary    )
        //2-Make the Experience filed inaccessible outside the class.
        public int ID;
        public String Name;
        public int Age;
        private int Experience;
        public double Salary;

        //3-Create at least 3 constructors(copy constructor, default constructor, parametrized constructor)
        public Employee() { }

        public Employee(int ID, String name, int age, int experience, double salary)
        {
            this.ID = ID;
            this.Name = name;
            this.Age = age;
            this.Experience = experience;
            this.Salary = salary;
        }

        public Employee(Employee other)
        {
            this.ID = other.ID;
            this.Name = other.Name;
            this.Age = other.Age;
            this.Experience = other.Experience;
            this.Salary = other.Salary;
        }

        //4-Create member function that displays all the fields
        public void display()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Experience: " + Experience);
            Console.WriteLine("Salary: " + Salary);
        }

        //5-Create member function that add 01% bonus for every experience year for the employee.
        public void addBonus()
        {
            Salary = (((Salary * 10) / 100) * Experience) + Salary;
        }

    }
}
