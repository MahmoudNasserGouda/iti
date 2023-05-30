using Day2Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2Demo.BusinessLogic
{
    public class EmployeeValidation
    {
        public static bool EmployeeIsValid(Employee employee)
        {
            bool found = false;
            foreach (var item in ApplicationContext.Employees)
            {
                if(item.ID == employee.ID)
                {
                    found = true;
                    break;
                }
            }
            return !found;
        }
    }
}