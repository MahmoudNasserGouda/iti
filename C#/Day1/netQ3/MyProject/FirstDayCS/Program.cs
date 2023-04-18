using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FirstDayCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Output&Input
            //Output To Screen
            //Console.Write("Welcome Group .Net");
            //Console.WriteLine("Welcomn");
            //Console.WriteLine("eee");

            ////Input "Take information From User"
            //Console.ReadLine();
            #endregion

            #region Varaibales

            //Decaler Var & Inilize Var 

            //DataType NameofVar=inilValue
            //DataType NameofVar
            // NameofVar=inilValue
            // DataType Numbers==> int float double long short
            //          String -==> string " "
            //          char ==> letter ' '
            //          boolean ==>bool ==> true false

            //float y = 10.8f;
            //double z = 4.6;

            //string Name = "sss";
            //char c = 'd';  //Must One letter , ' '

            //int number1,number2; //Decalre
            //int number3;
            //number2 = ""; //Error Diffrent DataType   // Inlize

            //string Name = "Nawal";
            //Name = "Ali";


            //string Name;
            //Console.WriteLine("Welcome");
            //Console.WriteLine("Enter Your Name :");
            //Name= Console.ReadLine();
            //Console.WriteLine("Hello " + Name);

            //Console.WriteLine("Enter First Number :");
            //int num1 = int.Parse(Console.ReadLine());  //From User ==> String   Casting ==> Convert From DataType to Anthor DataType
            //Console.WriteLine("Enter Second Number :");
            //int num2 = int.Parse(Console.ReadLine());

            //int result = num1 + num2;

            //Console.WriteLine("Sum = " + result);

            #endregion

            #region Implicty Typed
            //var x='s';
            //var y; //error  Implicty Typed var must be inilized

            //var x = 10.5;

            //var student = new {Name="Nawal",phone=3646464,isGrad=true };
            //Console.WriteLine(student);
            //Console.WriteLine(student.Name); //Get Value
            //                                 //student.Name = "Ali";  // erorr ==>Set Value "Read Only"




            #endregion

            #region Operation
            //Uni  -- ++
            //Binary
            //Tirnay

            //int x = 3;
            ////x++;
            ////x--;
            //Console.WriteLine(++x); //perfix
            //Console.WriteLine(x++); //postfix

            // + - * % /  x+y x*y

            //(condition)? true : false
            //string res= (3 > 4) ? "Red" : "Black";
            // Console.WriteLine(res);

            #endregion

            #region Conditions

            //int x = 3;
            ////if 
            ////if (x == 3 || x==5)
            ////{
            ////    if()  //Neated if
            ////    { }

            ////}
            ////else
            ////{
            ////    if ()  //Neated if
            ////    { }

            ////}
            //if ()
            //{ }
            //else if ()
            //{ }
            //else { }


            //char letter;

            //Console.WriteLine("Choose Your Char From A,B :");

            //letter =char.Parse(Console.ReadLine());
            //if (letter == 'A' || letter == 'a')
            //{
            //    Console.WriteLine("Apple");
            //}
            //else if (letter == 'B' || letter=='b')
            //{
            //    Console.WriteLine("Bus");
            //}
            //else
            //{
            //    Console.WriteLine("Please Enter From Two Letter A or B");
            //}

            //Switch

            //char letter;

            //Console.WriteLine("Enter Your Letter");

            //letter = char.Parse(Console.ReadLine());

            //switch (letter)
            //{
            //    case 'A':
            //    case 'a':
            //        Console.WriteLine("Exc");
            //        break;

            //    case 'B':
            //        Console.WriteLine("V.Good");
            //        break;

            //    case 'C':
            //        Console.WriteLine("Good");
            //        break;

            //    case 'D':
            //        Console.WriteLine("Fair");
            //        break;

            //    case 'F':
            //        Console.WriteLine("Fail");
            //        break;

            //   default:
            //      Console.WriteLine("Exit");
            //       break;

            //}


            //if (3 < 4)
            //{
            //    Console.WriteLine("3 is greater");
            //}
            //else if (3 > 5)
            //{
            //    Console.WriteLine("3 is greater");
            //}
            //else {
            //    Console.WriteLine();
            //  }


            //if (3 < 4)
            //{
            //    Console.WriteLine("3 is greater");
            //}
            // if (3 < 5)
            //{
            //    Console.WriteLine("3 is greater");
            //}
            //else
            //{
            //    Console.WriteLine();
            //}

            #endregion


            #region Loops
            // for while do while
            //for (int i = 1; i < 6; i++)
            //{ Console.WriteLine("Welcome"); }


            //int i = 1;
            //while (i < 6)
            //{
            //    Console.WriteLine("Welcome");
            //    i++;
            //}

            //Console.WriteLine("Enter Yes or No :");
            //string res = Console.ReadLine();

            //while (res == "yes")
            //{
            //    Console.WriteLine("Welcome Again !");
            //    Console.WriteLine("Enter Yes or No :");
            //    res = Console.ReadLine();
            //}

            //string res1;
            //do
            //{
            //    Console.WriteLine("Welcome Again !");
            //    Console.WriteLine("Enter Yes or No :");
            //     res1  = Console.ReadLine();
            //} while (true); //infinity Loop 


            //Break Contiue


            for (int i = 1; i < 10; i++)  //i=4
            {
                Console.WriteLine("Before IF");
                Console.WriteLine(i);

                if (i == 4)
                {
                    continue;
                    Console.WriteLine("After IF");
                    Console.WriteLine(i);
                 
                
                }


            }
            for (int i = 1; i < 10; i++)  //i=4
            {
                Console.WriteLine("Before IF");
                Console.WriteLine(i);

                if (i == 4)
                {
                    break;
                    Console.WriteLine("After IF");
                    Console.WriteLine(i);


                }


            }

            #endregion

        }
    }
}

