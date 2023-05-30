using Day2Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2Demo.BusinessLogic
{
    public class StudentValidation
    {
        public static bool StudentIsValid(Student student)
        {
            bool found = false;
            foreach (var item in ApplicationContext.Students)
            {
                if(item.ID == student.ID)
                {
                    found = true;
                    break;
                }
            }
            return !found;
        }
    }
}