using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator Overloading
            //  Point P1 = new Point(1, 1);
            //  Point P2 = new Point(2, 2);

            //  //int y = 5;
            //  //int x = 6;
            //  //int z = x + y;



            //  // Point P3 = new Point();
            //  //  Point P3 = P1.Add(P1, P2); //P3=Result
            //  //  P3.Display();

            //  //Point P3 =Point.Add(Point.Add(P1, P2),P2);

            //  //Point P3 = P1 + P2 + P2;

            //  //P3 = P1 - P2;

            //  //P3 = P1 + P2 - P1;
            //  //Console.WriteLine(6 > 5);

            //  //Console.WriteLine(P1 > P2);
            //  //// P1 < P2;

            //  //P3 = P1 + 6;
            //  //P3 = 6 + P1;

            //  //int x = 7;
            //  //double y = 8;

            //  //y =(double) x; // implicit casting 

            //  //x =(int) y; //explicit casting 


            //  //P1 = (Point)x; // P1 = x; //implicit 

            //  //x =(int) P1; //explicit

            ////  Console.WriteLine( P1 == P2); 
            #endregion

            #region Relations between classes 
            /* Relations between classes :
                * 1- Composition ==> Main Componant ==> Class A existance depends on Class B   
                * 2- Aggregation ==> Secondary - Minor Componant ==> Calss A existance will not depend on  Class B 
                * 3- Association ==> Using ===> Class A use Class B for small periods of time 
                * 4- Inheritance ==> is -A Relation 
                * */
            #region Composition Vs Aggeregation Vs Association

            //Wall[] W = new Wall[4];
            //Window[] W2 = new Window[4];

            //Room R1 = new Room(W, null);

            //Marker M1 = new Marker();
            //Instructor Inst = new Instructor();

            //Inst.WriteOnBoard(M1); 

            #endregion

            #region Inheritance

            //Person P = new Person();
            //P.Name = "ss";
            //P.Test();
            ////P.Age = 3; //Error, Protected 
            //P.Address = "jgf";
            //P.Gender = "lkj";

            //Employee E = new Employee();
            //E.Name = "E1";
            //E.Test();
            //E.Title = "kjhg";



            #endregion

            #endregion


            #region Types of Classes 

            //1- Concerte Class 
            //2- Static Class 
            //StaticClass SC = new StaticClass(); //Error, cannot create object from static class
            //3- Sealed Class ==> cannot inherit from it 
            //SealedClass S = new SealedClass();
            //4- Abstract Class ==> cannot create object from it 
            //AbstractClass A = new AbstractClass();
            //5- Partial Class 
            //Student S = new Student();
            //6- Nested Classes 
            //BMWFactory bMW = new BMWFactory();
            ////bMW.x = 4;
            //BMWFactory.Car C = new BMWFactory.Car();

            #endregion

            Console.ReadKey();
        }
    }
/*
 * Lec Summary :
 *  ===> Operator Overloading
 *  ===> Relations 
 *  ===> All type of classes
 *  
 *  Next Lec:
 *      ===> Rest of Inheritance 
 *      ===> Polymorphisem
 *     */ 
}
