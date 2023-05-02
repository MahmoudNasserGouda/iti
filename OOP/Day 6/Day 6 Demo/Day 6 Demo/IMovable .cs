using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Demo
{
    internal interface IMovable
    {


    

        //by default public + abstract + virtual 
        void MoveFor();
        void MoveBack();
        void MoveLeft();
        void MoveRight();

        


        //int x; //Error

        // int X { get; set; }
        //Car Test(Car C);
    }
}
