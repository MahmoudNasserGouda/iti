using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Metadata;
using Timer = System.Windows.Forms.Timer;
using System.IO;
using System.Windows.Forms;

namespace CustomControls
{
    public class HeartToggleButton : Control
    {
        private bool _isChecked = false;
        private Color _checkedColor = Color.Red;
        private Color _uncheckedColor = Color.Silver;

        public HeartToggleButton()
        {
        }

        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                if (_isChecked != value)
                {
                    _isChecked = value;
                    OnCheckedChanged(EventArgs.Empty);
                }
            }
        }

        public Color CheckedColor
        {
            get { return _checkedColor; }
            set
            {
                if (_checkedColor != value)
                {
                    _checkedColor = value;
                    Invalidate();
                }
            }
        }

        public Color UncheckedColor
        {
            get { return _uncheckedColor; }
            set
            {
                if (_uncheckedColor != value)
                {
                    _uncheckedColor = value;
                    Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            // Draw heart shape
            GraphicsPath heartPath = new GraphicsPath();
            RectangleF heartRect = new RectangleF(ClientRectangle.Location, new SizeF(ClientRectangle.Width, ClientRectangle.Height));

            int radius = (int)(Math.Min(ClientSize.Width, ClientSize.Height) * 0.6);
            Point center = new Point((int)(heartRect.X + heartRect.Width / 2), (int)(heartRect.Y + heartRect.Height * 0.3));

            heartPath.AddBezier(center.X, center.Y, 
                                center.X, center.Y - (radius / 2), 
                                center.X - (int)(radius * 0.8), center.Y - radius / 2, 
                                center.X - (int)(radius * 0.8), center.Y);
            heartPath.AddBezier(center.X - (int)(radius * 0.8), center.Y, 
                                center.X - (int)(radius * 0.8), center.Y + (radius / 2), 
                                center.X, center.Y + (int)(radius * 0.6), 
                                center.X, center.Y + radius);
            heartPath.AddBezier(center.X, center.Y + radius, 
                                center.X, center.Y + (int)(radius * 0.6), 
                                center.X + (int)(radius * 0.8), center.Y + (radius / 2),
                                center.X + (int)(radius * 0.8), center.Y);
            heartPath.AddBezier(center.X + (int)(radius * 0.8), center.Y, 
                                center.X + (int)(radius * 0.8), center.Y - (radius / 2), 
                                center.X, center.Y - (radius / 2), 
                                center.X, center.Y);

            // Draw heart fill
            Color fill = _isChecked ? _checkedColor : _uncheckedColor;
            using (SolidBrush brush = new SolidBrush(fill))
            {
                g.FillPath(brush, heartPath);
            }

            // Draw heart outline
            using (Pen pen = new Pen(Color.Black, 1.5f))
            {
                g.DrawPath(pen, heartPath);
            }
        }


        protected override void OnClick(EventArgs e)
        {
            IsChecked = !IsChecked;
        }

        protected virtual void OnCheckedChanged(EventArgs e)
        {
            EventHandler handler = CheckedChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        public event EventHandler CheckedChanged;
    }
}
