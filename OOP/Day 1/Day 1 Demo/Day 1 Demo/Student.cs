using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Demo
{
    internal class Student
    {
        #region Variables  ==> Fileds 

        public int ID;
        public string Name;
        public int Age;
        public int GPA;

        #endregion

        #region Methods

        public void Display()
        {
            Console.WriteLine($"ID:{ID}, Name: {Name},Age:{Age}, GPA:{GPA} ");
        }


        #endregion


    }
}
