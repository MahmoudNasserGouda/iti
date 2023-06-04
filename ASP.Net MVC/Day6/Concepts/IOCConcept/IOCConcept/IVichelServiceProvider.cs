using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IOCConcept
{
    class IVichelServiceProvider
    {
        public string Service { get; set; }

        public void Register(string _Service)
        {
            Service = _Service;
        }

        public IWorker Resolve()
        {
            //create service (low level class)
            var serviceObj = Activator.CreateInstance(Type.GetType("IOCConcept."+Service));

            //Injection: 
            //ctor injection
            IWorker worker = new Employee(serviceObj as IVichel);

            //property injection
            //worker.Car = new Car(0,"black");

            //method injection
            //worker.setVichel(new Car(0, "black"));
            return worker;
        }
    }
}
