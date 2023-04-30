using Day_3_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestInhritance
{
    internal class Manager :Person
    {
        public void TestAccess()
        {
            Name = "kjh";
            Age = 4;
            //Address = "jhg"; //Error
            Gender = "khjf";
        }
    }
}
