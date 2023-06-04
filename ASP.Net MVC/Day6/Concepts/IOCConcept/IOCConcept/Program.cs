using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            IVichelServiceProvider provider = new IVichelServiceProvider();
            provider.Register("VipCar");
            IWorker worker = provider.Resolve();
            Console.WriteLine(worker.Car.Accelerate());
        }
    }
}
