using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealWeightCalculator
{
    class Program
    {

        public static float Sum(float Item, float Item2)
        {
            return Item * Item2;
        }

        static void Main(string[] args)
        {
            #region Manaual Testing
            //Console.WriteLine(Sum(2, 2));
            //Console.WriteLine(Sum(2, 4)); 
            #endregion

            #region Simulation Automated Testing

            #region Test  Gender Male Height 170
            //float ExpectedResult = 65.4f;
            //WeightCalaculator We = new WeightCalaculator() { Gender = 'm', Height = 170 };

            //float ActualResult = We.GetIdealWeight();
            //if (ActualResult == ExpectedResult)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Test Success");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Test Faild");
            //} 
            #endregion

            #region Test Gender Female Height 160
            //float ExpectedResult = 55;
            //WeightCalaculator We = new WeightCalaculator() { Gender = 'f', Height = 160 };

            //float ActualResult = We.GetIdealWeight();
            //if (ActualResult == ExpectedResult)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Test Success");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Test Faild");
            //}

            #endregion

            #region Test Gender Bad Gender Height 170
            //float ExpectedResult = 0;
            //WeightCalaculator We = new WeightCalaculator() { Gender = ' ', Height = 170 };

            //float ActualResult = We.GetIdealWeight();
            //if (ActualResult == ExpectedResult)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Test Success");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Test Faild");
            //} 
            #endregion

            #endregion





            Console.ReadLine();
          
        }
    }
}
