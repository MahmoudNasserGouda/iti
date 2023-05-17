using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Employee
    {
        readonly ILogger logger;
        public Employee(ILogger _logger)
        {
            logger = _logger;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"ID:{ID}, Name:{Name}";
        }
        public void Add()
        {
            try
            {
                throw new OutOfMemoryException();
            }
            catch(Exception e)
            {
                logger.Log();
            }
        }
    }
}
