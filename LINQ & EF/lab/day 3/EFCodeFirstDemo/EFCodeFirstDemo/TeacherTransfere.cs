using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    internal class TeacherTransfere
    {
        public int ID { get; set; }

        public Teacher Teacher { get; set; }

        public School FromSchool { get; set; }

        public School ToSchool { get; set; }

        public DateTime Date { get; set; }

    }
}
