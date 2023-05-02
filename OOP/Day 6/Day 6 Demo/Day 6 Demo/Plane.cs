using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Demo
{
    internal class Plane : IFlyable //IMovable, IFlyable
    {


        #region Implementing Explicit
        //public void MoveFor()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMovable.MoveBack()
        //{
        //    throw new NotImplementedException();
        //}

        //void IFlyable.MoveBack()
        //{
        //    throw new NotImplementedException();
        //}

        //void IFlyable.MoveDown()
        //{
        //    throw new NotImplementedException();
        //}



        //void IMovable.MoveLeft()
        //{
        //    throw new NotImplementedException();
        //}

        //void IFlyable.MoveLeft()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMovable.MoveRight()
        //{
        //    throw new NotImplementedException();
        //}

        //void IFlyable.MoveRight()
        //{
        //    throw new NotImplementedException();
        //}

        //void IFlyable.MoveUp()
        //{
        //    throw new NotImplementedException();
        //} 
        #endregion
        void IMovable.MoveBack()
        {
            throw new NotImplementedException();
        }

        void IFlyable.MoveDown()
        {
            throw new NotImplementedException();
        }

        void IMovable.MoveFor()
        {
            throw new NotImplementedException();
        }

        void IMovable.MoveLeft()
        {
            throw new NotImplementedException();
        }

        void IMovable.MoveRight()
        {
            throw new NotImplementedException();
        }

        void IFlyable.MoveUp()
        {
            throw new NotImplementedException();
        }
    }
}
