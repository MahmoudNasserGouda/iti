using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Demo
{
    internal class Car
    { 
    
        //Encapsulation ===> forced using access modifiers

        public string ModelName;
        public string Color;
        private double _price; //Hide field from anyone outside the class, ==> Class scope

        //by default => private 
         string engine;

        #region Proprties
        //Full Proprty
        public double Price
        {
            get
            {
                return _price;
            }
            set //==> value ==> hidden param 
            {
                if (value >= 5000)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price must be greater than 5000");
                    _price = 5000;
                }
            }
        }

        private int _code;

        public int Code
        {
            get { return _code; }
        }

        //Auto Implemented Proprty 
        public int ModelNumber { get; set; } = 111;

        //error
        //public int test { get; 
        //    set
        //    {

        //    } 
        //}


        //User get & set ==> old approach
        //public void SetPrice(double price)
        //{
        //    if(price > 5000)
        //    {
        //        Price = price;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Price must be greater than 5000");
        //        Price = 5000;
        //    }
        //}

        //public double GetPrice()
        //{
        //    return Price;
        //}



        #endregion

        public Car()
        {
            _price = 5000;
            ModelNumber = 111;
            ModelName = "Audi";
            Color = "Black";
        }

        //private Constructor
        //private Car()
        //{
        //    //....
        //}

        public Car(double price) 
        {
            if (price >= 5000)
            {
                this.Price = price;
            }
            else
            {
                Price = 5000;
            }

            ModelNumber = 111;
            ModelName = "Audi";
            Color = "Black";
        }

        public void Display()
        {
            Console.WriteLine($"Price:{_price}");
        }

        //private by default 
        void startEnging()
        {
           
        }
        public void Move()
        {
            startEnging();
            Console.WriteLine("Car is Moving....");
        }
        public void Stop()
        {
            Console.WriteLine("Car Stopped...");
        }


    }
}
