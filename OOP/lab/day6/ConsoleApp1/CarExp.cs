using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CarExp : IVehicle, IDrivable
    {
        public int Gas { get; set; }
        public CarExp(int gas)
        {
            Gas = gas;
        }

        void IVehicle.Drive()
        {
            if (Gas > 0)
            {
                Console.WriteLine("Car is Driving");
            }
        }

        bool IVehicle.Refuel(int amount)
        {
            if (amount > 0)
            {
                Gas += amount;
                return true;
            }
            else
            {
                return false;
            }

        }

        void IDrivable.Move()
        {
            Console.WriteLine("Car is Moving");
        }

        void IDrivable.Accelerate()
        {
            Console.WriteLine("Car is Accelerating");
        }

        void IDrivable.Drive()
        {
            if (Gas > 0)
            {
                Console.WriteLine("Car is Driving");
            }
        }
    }
}
