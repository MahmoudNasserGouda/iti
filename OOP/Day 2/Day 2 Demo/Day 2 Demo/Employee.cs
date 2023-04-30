using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Demo
{
    internal class Employee
    {
        #region Fields 

        public int ID;
        public string Name;
        public float Salary;
        public string Address;


        #endregion

        #region Static Fields
        private static string DeptName;
        public static int Count;
        #endregion


        #region Constructor 

        //Constructor Rules:
        //1- Must has the same name as the class 
        //2- cannot have return type 


        //Parametrized Constructor  ==> force logic 
        //==> Constructor Overloading
        //==> differe in no. param 
        //==> order of data types of param
        public Employee(int iD, string name, float salary, string address)
        {
            ID = iD;
            if(name != null && name.Length>=3)
            {
                Name = name;

            }
            else
            {
                Name = "N/A";
            }
            if(salary>=3000)
            {
                Salary = salary;

            }
            else
            {
                Salary = 3000;
            }
            if(address != null & address.Length>=3)
            {
                Address = address;

            }
            else
            {
                Address = "Minia";
            }
            Count += 1;

        }

        public Employee(string name, string address):this(1,name,3000,address)
        { 
            //any other logic if needed
        }

        //Constructor Chaining 
        public Employee(string Name, float salary):this(1,Name,salary,"Minia")
        {
            //ID = 1;
            //Address = "Minia";

            //if (Name != null && Name.Length >= 3)
            //{
            //    this.Name = Name; //must use this, same name var.

            //}
            //else
            //{
            //    Name = "N/A";
            //}
            //if (salary >= 3000)
            //{
            //    Salary = salary; //using this== optional

            //}
            //else
            //{
            //    Salary = 3000;
            //}
            //Count += 1;


        }
        public Employee(string name):this(1,name,3000,"Minia")//this(name,"Minia")==> not the best practice, ==> chian with the constructor that holds the logic 
        { }

        //Copy Constructor 
        public Employee(Employee E):this(E.ID,E.Name,E.Salary,E.Address)
        {
            ////Deep Copy 
            //ID = E.ID;
            //Name = E.Name;
            //Salary = E.Salary;
            //Address = E.Address;
        }


        //Default Constructor ==> does not have any params..
        public Employee():this(1,"N/A",3000,"Minia")
        { }



        //Static Constructor 
        //will be called automatically with the first interaction with the class
        //called only once 
        static Employee()
        {
            Console.WriteLine("Inside static constructor");
            DeptName = ".Net";
            Count = 0;
        }


        #endregion



        #region Methods 

        public void Display()
        {
            //can have static or non- static fields 
            Console.WriteLine($"ID:{this.ID}, Name:{this.Name}, Salary:{Salary}, Address:{Address}, DeptName={DeptName}");
        }

        public void Test(int x)
        {
            this.Name = "v";
        }

        //Static Method 
        public static void Show()
        {
            Console.WriteLine($"Count={Count}");
            //Console.WriteLine($"ID={ID}");  //Can have only static fields
        }

        #endregion



    }
}
