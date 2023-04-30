using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        //static void Greeting() {

        //    Console.WriteLine("Welcome");
        //}

        //No Return ,Zero Parameter
        //static void Greeting()
        //{

        //    Console.WriteLine("Welcome");
        //    if (DateTime.Now.Hour <= 12)
        //        Console.WriteLine("GoodMonring");
        //    else
        //        Console.WriteLine("GoodNight");
        //}

        //static void printName(string Name)
        //{
        //    Console.WriteLine(Name);
        //}

        static string printName(string Name)
        {
            return Name;
        }

        static int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static float div(int x,int y)
        {
            return (float)x / y;
        }

        static char print()
        {
            return 'A';
        }

        //Passing By Value . Passing By Ref.
        //static string Swap(int num1 , int num2)
        //{

        //    int temp;
        //    temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //    //Console.WriteLine("From Fun **** After Swaping *****");
        //    //Console.WriteLine("Num1 :"+num1);
        //    //Console.WriteLine("Num2 :"+num2);

        //    return "num1 :" + num1 + "    num2 :" + num2;
        //}
        static string Swap(ref int num1,ref int num2)
        {

            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            //Console.WriteLine("From Fun **** After Swaping *****");
            //Console.WriteLine("Num1 :"+num1);
            //Console.WriteLine("Num2 :"+num2);

            return "num1 :" + num1 + "    num2 :" + num2;
        }

        static float AVG(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;

            }

            float res = sum / arr.Length;
            return res;

        }
        //static void Doubling(int[] arr)
        //{
           
        //   for(int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] *= 2;

        //    } 

        //}
        static int [] Doubling(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;

            }
            return arr;
        }

        static int fact(int num)
        {
            if (num == 1)
                return 1;
            else
                return num * fact(num - 1);
        }
        static void Main(string[] args)
        {
            //string stdName1,stdName2, stdName3, stdName4, stdName5;
            //Console.WriteLine("Enter Your StdName");
            //stdName1 = Console.ReadLine();
            //Console.WriteLine("Enter Your StdName");
            //stdName2 = Console.ReadLine();
            //Console.WriteLine("Enter Your StdName");
            //stdName3 = Console.ReadLine();
            //Console.WriteLine("Enter Your StdName");
            //stdName4 = Console.ReadLine();
            //Console.WriteLine("Enter Your StdName");
            //stdName5 = Console.ReadLine();

            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine("Enter Your StdName");
            //    stdName1 = Console.ReadLine();
            //}

            #region Array 1D
            //DT [] ArrayName=new DT [Size];
            //Array --> Fixed Size , The Same DataType
            //int[] Numbers = new int[] { 1,2,3,4};
            // int[] Numbers = new int[5];
            //int[] arr;
            //arr = new int[2]; 

            //Set Values in Array
            //Numbers[0] = 10;
            //Numbers[1] = 20;
            //Numbers[2] = 30;
            //Numbers[3] = 40;
            //Numbers[4] = 50;

            // Get Values From Array
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);

            //Console.WriteLine(Numbers.Length);
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine("Enter Your Numbers :");
            //    Numbers[i] =int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //int sizeOfArr=0;
            //string[] stdName;

            //Console.WriteLine("Enter Your Size of Array! ");
            //sizeOfArr = int.Parse(Console.ReadLine());
            //stdName = new string[sizeOfArr];

            //for (int i = 0; i < stdName.Length; i++)
            //{
            //    Console.WriteLine("Enter Your Numbers :");
            //    stdName[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < stdName.Length; i++)
            //{
            //    Console.WriteLine(stdName[i]);
            //}


            //char[] letters = new char[0];
            //Console.WriteLine(letters.Length);
            //letters[0] = 'A';
            //Console.WriteLine(letters[0]);

            #endregion

            #region Array 2D
            ////Nested Loop
            //for (int i = 0; i < 3; i++) //i=3
            //{
            //    for (int j= 0; j < 2; j++) //j=2
            //    {
            //        Console.WriteLine("Welcome");
            //    }
            //}
            //int[,] nums = new int[2,3];
            //for (int i = 0; i < 2; i++) //i=3
            //{
            //    for (int j = 0; j < 3; j++) //j=2
            //    {
            //        nums[i,j]= int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 2; i++) //i=3
            //{
            //    for (int j = 0; j < 3; j++) //j=2
            //    {
            //        Console.WriteLine(nums[i, j]);
            //    }
            //}
            #endregion

            #region  ArrayList
            //Not Fixed Size and not the Same DataType
            //ArrayList numbers = new ArrayList();
            //numbers.Add(1);
            //numbers.Add(100);
            //numbers.Add("Nawal");
            //numbers.Add(10.0);
            //numbers.Add(11.3f);
            //numbers.Add('A');
            //numbers.Add(true);
            //ArrayList arr2 = new ArrayList();
            //arr2.Add("Zaki");
            //arr2.Add(100);
            //numbers.AddRange(arr2);
            //numbers.Insert(4, "NewElement");
            //numbers.InsertRange(4, arr2);
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region List
            //Not fixed Size , The Same DataType
            //List<int> numbers = new List<int>();
            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);
            //numbers.Add(40);
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);

            //}

            //////Console.WriteLine("Enter Your Size Of Your List !");
            //////int Size =int.Parse(Console.ReadLine());

            //////for (int i = 0; i <Size; i++)
            //////{
            //////    numbers.Add(int.Parse(Console.ReadLine()));

            //////}
            //numbers.Sort();
            //numbers.Remove(100);
            //numbers.Reverse();
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item); //The Same ==>For of in Javascript
            //}

            #endregion

            #region   Dictionary
            //Key ==> AnyDataType , Value ==> AnyDataType
            //Dictionary<string, float> StudentDegree = new Dictionary<string, float>();
            //StudentDegree.Add("Nawal", 12.2f);
            //StudentDegree.Add("Ahmed", 3.5f);
            //StudentDegree.Add("Ali", 1.2f);
            //StudentDegree.Add("Mohammed", 12.33f);

            //foreach (var item in StudentDegree)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}

            //foreach (float item in StudentDegree.Values)
            //{
            //    Console.WriteLine(item); // item==> Values
            //}

            //foreach (string item in StudentDegree.Keys)
            //{
            //    Console.WriteLine(item); // item==> Keys
            //}

            //Console.WriteLine("Enter Your Name");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Enter Your GPA");
            //float GPA =float.Parse(Console.ReadLine());

            //StudentDegree.Add(Name, GPA);

            //foreach (var item in StudentDegree)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(StudentDegree.Contains(new KeyValuePair<string, float>("Osama",4.5f)));

            //Console.WriteLine(StudentDegree.ContainsKey(Name));
            //Console.WriteLine(StudentDegree.ContainsValue(GPA));

            //Console.WriteLine(StudentDegree[Name]); //Get Value For Speific Key
            ////Change Value 
            //StudentDegree[Name] = 200.5f;
            #endregion

            #region ValueType & ReferenceType

            //Ref. Type
            //List<float> list1=new List<float>();
            //list1.Add(1.0f);
            //list1.Add(2.0f);
            //list1.Add(3.0f);
            //list1.Add(4.0f);

            //List<float> list2 = list1;

            //list2.Add(100.0f);

            //foreach (float x in list1)
            //    Console.WriteLine(x);

            //foreach (float x in list2)
            //    Console.WriteLine(x);


            ////Value Type
            //int x = 3;
            //float y= 3.4f;
            #endregion


            //Boxing Unboxing


            #region Funtions

            //Greeting();
            //printName("Ahmed");

            //string res=printName("Nawal");
            //Console.WriteLine(res);

            //sum(10, 20);

            //int x = 3, y = 4;
            //Console.WriteLine("Out Fun **** Before Swaping *****");
            //Console.WriteLine("Num1 :" + x);
            //Console.WriteLine("Num2 :" + y);

            ///* Console.WriteLine("Out Fun **** After Swaping *****" +Swap(x, y)); */ //Passing By Value
            //Console.WriteLine("Out Fun **** After Swaping *****" + Swap(ref x,ref y)); //Passing By REf.
            //Console.WriteLine("Num1 :" + x);
            //Console.WriteLine("Num2 :" + y);

            //int[] nums = new int[3] { 10,20,15};
            ////AVG(nums);

            //int [] res= Doubling(nums);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            // !5=5*4*3*2*1

            int number = 5;
            int fact = 1;
            while(number>1)
            {
                fact *= number--;
            }
            Console.WriteLine(fact);

            #endregion



        }
    }
}
