using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Demo
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Creating Object
            //int x;
            //int y = 5;


            //Student S1; // Ref Only 
            //Student S2 = new Student(); // Createing Object 
            //                            //new ==> place variable in memeory 
            //                            //constructor => Student() ==> intialize value for variables 

            //// ID=1 //error, must use object name (Ref)
            //S2.ID = 1;
            //S2.Name = "Ahmed";
            //S2.Age = 21;
            //S2.GPA = 3;
            //S2.Display(); 
            #endregion

            #region Shallow Copy Vs Deep Copy 
            //Student S1 = new Student();

            ////Shallow Copy  ==> copy ref address only
            //Student S2 = S1;

            //S1.ID = 1;
            //S1.Name = "Ali";
            //S1.GPA = 3;
            //S1.Age = 21;

            ////Console.WriteLine("Before update...");
            ////S1.Display();
            ////S2.Display();


            ////S2.GPA = 5;
            ////Console.WriteLine("After update...");

            ////S1.Display();
            ////S2.Display();


            ////Deep Copy ==> copy values of the object
            //Student S3 = new Student();
            //S3.ID = S1.ID;
            //S3.Name = S1.Name;
            //S3.GPA = S1.GPA;
            //S3.Age = S1.Age;

            //Console.WriteLine("Before update...");

            //S1.Display();
            //S3.Display();

            //S3.GPA = 5;
            //Console.WriteLine("After update...");

            //S1.Display();
            //S3.Display(); 
            #endregion


            #region Array of Objects 

            //int[] arr = new int[3];

            //Student[] students = new Student[3];

            ////Console.WriteLine(students[0].ID); //error ,must create object first in each index of array 

            ////students[0]= new Student(); //creating object

            //for (int i = 0; i < students.Length; i++)
            //{
            //    students[i] = new Student(); 
            //}
            




            #endregion


            Console.ReadKey();
        }

        /* Lec Summary :
         *  ===> Linear Prog Vs Strucutred Prog. 
         *  ===> OOP & concepts in general 
         *  ===> Class Vs Object 
         *  ===> Creating objects using new keyword + deafult constructor 
         *  ===> Shallow copy vs Deep Copy 
         *  ===> Array of objects 
         *  
         * Next Lec :
         *  ===> Types Constructors 
         *  ===> Static Keyword 
         *  ===> Encapsulation 
         *  */
    }
}
