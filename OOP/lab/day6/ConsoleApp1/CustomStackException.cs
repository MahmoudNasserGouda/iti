using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomStackException : Exception
    {
        public CustomStackException() { }

        public CustomStackException(string message) : base(message) { }

        public CustomStackException(string message, Exception innerException) : base(message, innerException) { }
    }
}
