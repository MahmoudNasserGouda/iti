using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCConcept
{
    class Employee:IWorker
    {
        public string Name { get; set; }

        //poperty injection
        public IVichel Car { get; set; }

        public Employee(IVichel vichel)
        {
            //Wrong tightly coupled way
            //Car = new Car();

            //Factory Design pattern
            //Car = VichleFactory.GetCar();

            //ctor injection
            Car = vichel;
        }

        //Method Injection
        public void setVichel(IVichel vichel)
        {
            Car = vichel;
        }
    }
}
