namespace ConsoleApp1
{
    public class Line
    {
        private Point _start;

        public Point Start
        {
            get { return _start; }
            set
            {
                if (value != null)
                {
                    _start = value;
                }
                else
                {
                    _start = new Point();
                }
            }
        }

        private Point _end;

        public Point End
        {
            get { return _end; }
            set
            {
                if (value != null)
                {
                    _end = value;
                }
                else
                {
                    _end = new Point();
                }
            }
        }
        public Color Color { get; set; }

        public Line(Point start, Point end, Color color)
        {
            if (start != null)
            {
                _start = start;
            }
            else
            {
                _start = new Point();
            }
            if (end != null)
            {
                _end = end;
            }
            else
            {
                _end = new Point();
            }
            Color = color;
        }

    }
}
