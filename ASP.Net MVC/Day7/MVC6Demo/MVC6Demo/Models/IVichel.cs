using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC6Demo.Models
{
    public interface IVichel
    {
        int Code { get; set; }
        string Color { get; set; }
        string Accelerate();
    }
}
