using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Utility
    {
        public static int GetInetger()
        {
            int value = 0;
            value = int.Parse(Console.ReadLine());
            if (value <= 0)
                throw new IDMustBeGreaterThanOrEqualOneException("Value Can't Be Zero or Negative");
            return value;
        }
    }
}
