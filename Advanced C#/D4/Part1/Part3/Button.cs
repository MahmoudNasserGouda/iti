using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public delegate void CallMe(Button obj);
    public class Button
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public CallMe OnClick { get; set; }
        public void Clicked()
        {
            if(OnClick!=null)
                 OnClick(this);
        }
    }
}
