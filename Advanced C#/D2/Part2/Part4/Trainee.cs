using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public class Trainee
    {
        public int ID;
        public string Name;

        ~Trainee()
        {
            Console.WriteLine( "Dying ..");
        }
    }
}
