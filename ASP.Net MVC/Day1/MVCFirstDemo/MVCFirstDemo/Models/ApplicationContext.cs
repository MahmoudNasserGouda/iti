using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirstDemo.Models
{
    public class ApplicationContext
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student(){ ID = 1, Name = "STD01", GPA = 3.7f},
            new Student(){ ID = 2, Name = "STD02", GPA = 3.7f},
            new Student(){ ID = 3, Name = "STD03", GPA = 3.7f}
        };
    }
}