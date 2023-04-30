using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Demo
{
    internal class Employee :Person //:AbstractClass //:SealedClass , Error
    {
        public string Title;

        public void Show()
        {
            //ID = 33; //error, private in parent 
            Age = 33;
            Address = "jhfg";
            Gender = "kjgh";
     
        }

    }


    //Multi-level 
    //class Manger :Employee
    //{

    //}
}
