using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Object 
            ////    Car C = new Car("Red");

            ////    Car C2 = new Car("Blue");
            ////    Console.WriteLine(C.Equals(C2)); 
            #endregion

            #region Abstraction 

            //Vehicle V = new Vehicle();
            //V.Move(); 

            //IMovable I = new IMovable(); //Error

            //AutoCar A = new AutoCar();
            //A.MoveFor();

            //Cat cat = new Cat();

            ////IMovable I = A;
            //OpenDoor(A);
            //OpenDoor(cat);

            //Plane P = new Plane();
            ////P.MoveBack();

            //IMovable I = P;
            //I.MoveBack();

            //IFlyable Fly = P;
            //Fly.MoveBack();


            #endregion

            Console.ReadKey();
        }

        public static void OpenDoor(IMovable I)
        {
            I.MoveFor();
            I.MoveBack();
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////

        //Generics
        //Delegets 
        //Lymda Experssion
        //Anonumous Type
        //Arrow Functions 
        //Extesion Method 
        //Custom Error
        //yield return 
        //Events 
        //Windows forms
        //Async , await
        //Threading 
        //Indexer
        //Enum


        ///////////////////////////////////////////////////////////////////////////////////////////////

    }
}
