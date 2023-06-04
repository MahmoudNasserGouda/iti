using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCConcept
{
    interface IWorker
    {
        string Name { get; set; }

        IVichel Car { get; set; }

        void setVichel(IVichel vichel);
    }
}
