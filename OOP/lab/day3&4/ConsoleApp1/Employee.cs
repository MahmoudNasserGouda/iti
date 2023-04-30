using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    //Day 4 Assignment
    //1-Create a new class and name it Employee.Set its access modifier to public so it can be instantiated from any project.
    //Every person has a name, and age.
    //a.Define the Name and Age properties of a Person.
    //Ensure that they can only be changed by the class itself or its descendants(pick the most appropriate access modifier).
    //2-Add 3 different fields with 3 different access modifiers(internal, protected, protected internal),
    //and try to access them through the child class.
    //3-Add a method "ShowData" to display the data of the class.
    //4-Create a Manager class that inherits from Employee and try accessing the parents’ fields.
    //5-Implement the Composition and the Aggregation or Association relation between classes(Point, Line, Color).
    //Bonus:b 
    //1-Hide the method "ShowData" of the base class.
    //2-Call the person "ShowData" through the child method.

    public class Employee
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }

        internal int Salary { get; set; }
        protected string PhoneNumber { get; set; }
        protected internal string Email { get; set; }

        public Employee(string name, int age, int salary, string phoneNumber, string email)
        {
            Name = name;
            Age = age;
            Salary = salary;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void ShowData()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}, Phone: {PhoneNumber}, Email: {Email}");
        }
    }
}
