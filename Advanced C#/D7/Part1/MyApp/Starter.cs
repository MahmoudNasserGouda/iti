using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITI;

namespace MyApp
{
    public partial class Starter : Form
    {
        public Starter()
        {
            clock = new LabledClock();
            clock.Parent = this;
           
        }
    }
}
