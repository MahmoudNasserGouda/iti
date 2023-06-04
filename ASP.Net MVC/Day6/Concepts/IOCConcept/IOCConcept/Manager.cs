using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCConcept
{
    class Manager: IWorker
    {
        public string Name { get; set; }

        public IVichel Car { get; set; }
        public Manager()
        {
            Car = VichleFactory.GetCar();
        }

        public void setVichel(IVichel vichel)
        {
            throw new NotImplementedException();
        }
    }
}
