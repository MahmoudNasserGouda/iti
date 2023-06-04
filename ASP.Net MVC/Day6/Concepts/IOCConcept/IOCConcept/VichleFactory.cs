using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCConcept
{
    class VichleFactory
    {
        public static IVichel GetCar()
        {
            return new VipCar();
        }
    }
}
