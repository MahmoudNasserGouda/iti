using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealWeightCalculator
{
   public class WeightCalaculator
    {
        //For calculating the ideal body - weight(w) of a subject;
        //for men: w = (height[cm]− 100) − ((height − 150)/ 4);
        //for women: w = (height − 100) − ((height − 150)/ 2);


        public float Height { get; set; }
        public char Gender { get; set; }

        public float GetIdealWeight()
        {
            switch (Gender)
            {
                case 'f':
                    return ((Height - 100) - ((Height - 150) / 2));
                case 'm':
                    return ((Height - 100) - ((Height - 150) / 4));
                default:
                    throw  new ArgumentException();

            }
        }


    }
}
