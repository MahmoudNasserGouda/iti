using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class EMployee
    {
        public int ID;
        public string Name;
        public EMployee() { }
        public EMployee(ref EMployee E)
        {

        }
        public override string ToString()
        {
            return $"ID : {ID}";
        }
    }
    
}
