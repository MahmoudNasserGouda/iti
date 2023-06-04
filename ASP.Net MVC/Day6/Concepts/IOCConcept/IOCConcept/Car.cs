using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCConcept
{
    //D from SOLID
    class Car : IVichel
    {
        public int Code { get; set; }
        public string Color { get; set; }

        public Car()
        {
           
        }

        public Car(int _code, string _color)
        {
            Code = _code;
            Color = _color;
        }

        public string Accelerate()
        {
            return $"Car {Code} is accelerating";
        }
    }
}
