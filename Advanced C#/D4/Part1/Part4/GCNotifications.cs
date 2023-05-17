using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public delegate void GCWorking(int generation);
    public class GCNotifications
    {
        private static GCWorking list; 
        public static GCWorking GCDone
        {
            set
            {
                for (int i = 0; i < 20; i++)
                    new GCObj();
                list += value;
            }
            get
            {
                return list;
            }
        }
        class GCObj
        {
            ~GCObj()
            {
                list(GC.GetGeneration(this));
            }
        }
    }
}
