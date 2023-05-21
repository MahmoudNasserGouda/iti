using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    internal class Teacher
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public School School { get; set; }

        public string NationalID { get; set; }
    }
}
