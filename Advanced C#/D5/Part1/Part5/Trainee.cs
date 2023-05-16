using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class Trainee : BaseModel
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return $"ID:{ID}, Name:{Name}";
        }
    }
}
