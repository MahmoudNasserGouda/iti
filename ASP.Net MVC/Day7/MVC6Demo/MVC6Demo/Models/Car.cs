using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC6Demo.Models
{
    public class Car : IVichel
    {
        

        public int Code { get; set; }
        public string Color { get; set; }

        public string Accelerate()
        {
            return $"Car {Code} is accelerating";
        }
    }
}
