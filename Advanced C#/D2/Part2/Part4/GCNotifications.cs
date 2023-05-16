using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public class GCNotifications
    {
        private static Action<int> list = null; 
        public static event Action<int> GCDone
        {
            add
            {
                new GCObj(0);
                new GCObj(2);
                list += value;
            }
            remove
            {
                list -= value;
            }
        }

        public sealed class GCObj
        {
            private int genration;
            public GCObj(int _generation) 
            {
                this.genration = _generation;
            }
            ~GCObj()
            {
                if(GC.GetGeneration(this) >= genration)
                {
                    Action<int> t = Volatile.Read(ref list);
                    t.Invoke(genration);
                }

                if(list != null)
                {
                    if(genration == 0) { new GCObj(0); }
                    else
                    {
                        GC.ReRegisterForFinalize(this);
                    }
                }
            }
        }
    }
}
