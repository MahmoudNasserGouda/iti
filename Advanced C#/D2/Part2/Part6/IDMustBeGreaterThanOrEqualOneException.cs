using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6
{
    public class IDMustBeGreaterThanOrEqualOneException : Exception
    {
        public IDMustBeGreaterThanOrEqualOneException
            (string _msg) : base (_msg)
        {
        }
    }
}
