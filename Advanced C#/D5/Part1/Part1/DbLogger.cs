using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class IDbLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Balh Balh Balh");
        }
    }
}
