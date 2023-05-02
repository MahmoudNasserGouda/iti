using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car : IVehicle, IDrivable
    {
        public int Gas { get; set; }
        public Car(int gas)
        {
            Gas = gas;
        }

        public void Drive()
        {
            if (Gas > 0)
            {
                Console.WriteLine("Car is Driving");
            }
        }

        public bool Refuel(int amount)
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

        public void Move()
        {
            Console.WriteLine("Car is Moving");
        }

        public void Accelerate()
        {
            Console.WriteLine("Car is Accelerating");
        }
    }
}
