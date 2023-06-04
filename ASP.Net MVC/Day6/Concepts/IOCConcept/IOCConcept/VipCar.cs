using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCConcept
{
    class VipCar : IVichel
    {
        public int Code { get; set; }
        public string Color { get; set; }

        public string Accelerate()
        {
            return "Vip Car is Accelerating";
        }
    }
}
