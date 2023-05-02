using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Demo
{
    internal interface IFlyable:IMovable
    {
        //void MoveFor();
        //void MoveBack();
        //void MoveLeft();
        //void MoveRight();
        void MoveUp();
        void MoveDown();


    }
}
