using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polymorphisem 
            //1- Dynamic Binding ==> Run time Poly. ===> Method Hiding , Method Override 
            //2- Static Binding ===> Compile time Poly.  ==> Method Overloading 

            #region Method Hiding
            //Car C = new Car();
            //C.Move(); //Calls Car Fun.  
            #endregion


            #region Method Overriding
            ////V = C;
            ////V.Stop();//Error
            ////C =(Car) V; //Excption

            ////Vehicle V = new Vehicle();
            ////V.MoveLeft();

            ////Override
            ////Vehicle V2 = new Car();
            ////V2.Move();
            ////V2.MoveLeft();

            ////Car C = new Car();
            ////C.Move();
            ////C.MoveLeft();

            ////Vehicle V1 = new Car();
            ////Park(V1);
            ////Vehicle V2 = new Buss();
            ////Park(V2);

            //Vehicle V = new AutoCar();
            //V.MoveLeft();
            //V.MoveRight();


            //Car c = new AutoCar();
            //c.MoveRight();

            ////AutoCar A = new AutoCar();
            ////A.Move();
            ////A.MoveLeft(); 
            #endregion



            Console.ReadKey();
        }
        public static void Park(Vehicle V)
        {
            V.MoveLeft();

        }
    }

  /* Lec Summary:
   *        ===> base Keyword 
   *        ===> Ploymorphisem 
   *            ===> Dynamic Binding 
   *                ===> Method Hiding 
   *                ===> Method Override 
   *            ===> Static Binding 
   *                ===> Method Overloading 
   *         ===> Sealed Function       
   * */


}
