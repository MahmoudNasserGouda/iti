using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI
{
    public class LabledClock : Control
    {
        private bool IsStarted = false;
        private System.Threading.Timer timer;
        public string Label { get; set; }
        public new Font Font { get; set; }
        public Brush Brush { get; set; }
        public LabledClock()
        {
            Label = "Your Text Here";
            Font = new Font("Arial", 10);
            Brush = Brushes.Black;
            Draw();
        }
        private void Draw()
        {
            Graphics G = CreateGraphics();
            G.FillRectangle(Brushes.White, DisplayRectangle);
            Label = "";
            Label += Environment.NewLine;
            Label += DateTime.Now.ToLongTimeString();

            G.DrawString
                (Label, Font, Brush,
                new PointF(
                    (ClientRectangle.Width - G.MeasureString(Label,Font).Width)/2,
                    (ClientRectangle.Height - G.MeasureString(Label, Font).Height) / 2
                    ));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if(IsStarted==false)
            {
                timer = new System.Threading.Timer
                ((obj) => { Draw(); }, null, 0, 1000);

                IsStarted = true;
            }
            base.OnPaint(e);
        }
    }
}
