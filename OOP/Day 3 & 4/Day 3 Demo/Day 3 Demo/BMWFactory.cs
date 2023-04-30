using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Demo
{
    //outer class
    internal class BMWFactory
    {
        int x;
        public int y;
        Car C;

        public void Test()
        {
           // C.w = 54; //error
        }

        //Nested class, inner class
       internal class Car 
        {
            int w;
            public int z;
            BMWFactory BMW;
            public void show()
            {
                BMW.x = 8976; //can access private fields
                BMW.y = 96;

                
            }
        }

    }
}
