using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCConcept
{
    //D from SOLID
    interface IVichel
    {
        int Code { get; set; }
        string Color { get; set; }

        string Accelerate();
    }
}
