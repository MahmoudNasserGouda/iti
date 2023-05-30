using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2Demo.Models
{
    public class ApplicationContext
    {
        public static List<Employee> Employees = new List<Employee>() {
            new Employee(){ ID = 1, Salary = 3000, Name = "Ahmed"},
            new Employee(){ ID = 2, Salary = 3500, Name = "Mahmoud"},
            new Employee(){ ID = 3, Salary = 2700, Name = "Saeed"},
            new Employee(){ ID = 4, Salary = 1800, Name = "Nour"}
        };

        public static List<Student> Students = new List<Student>() {
            new Student(){ ID = 1, GPA = 3.7f, Name = "STD01"},
            new Student(){ ID = 2, GPA = 3.2f, Name = "STD02"},
            new Student(){ ID = 3, GPA = 2.7f, Name = "STD03"},
            new Student(){ ID = 4, GPA = 1.7f, Name = "STD04"}
        };

    }
}