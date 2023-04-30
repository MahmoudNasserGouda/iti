using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Demo
{
    internal class Point
    {
        int _xCord;
        int _yCord;

        static int _count;

        //public static int Count
        //{
        //    get { return _count; }
        //}

        public int XCord
        {
            get { return _xCord; }
            set
            {
                if(value >0 )
                {
                    _xCord = value;
                }
                else
                {
                    _xCord = 1;
                }
            }
        }
        public int YCord
        {
            get { return _yCord; }
            set
            {
                if (value > 0)
                {
                    _yCord = value;
                }
                else
                {
                    _yCord = 1;
                }
            }
        }

        static Point()
        {
            _count = 0;
        }
        public Point (int xcord, int ycord)
        {
            if(xcord>0)
            {
                _xCord = xcord;
            }
            else
            {
                _xCord = 1;
            }

            if (ycord > 0)
            {
                _yCord = ycord;
            }
            else
            {
                _yCord = 1;
            }

            _count += 1;

        }

        public Point(int xcord):this(xcord,1)
        { }

    

        public Point(Point P):this(P._xCord,P._yCord)
        { }

        public Point() : this(1, 1)
        { }

        public Point Clone(Point P)
        {
            return new Point(P);
        }


        public void Display()
        {
            Console.WriteLine($"({_xCord},{_yCord})");
        }

        //Px=P1 , Py = P2
        //public Point Add(Point Px, Point Py)
        //{
        //    //Point Result = new Point();
        //    //Result._xCord = Px._xCord + Py._xCord;
        //    //Result._yCord = Px._yCord + Py._yCord;

        //    //return Result;

        //    return new Point(Px._xCord + Py.XCord, Px._yCord + Py._yCord);

        //}

        public static Point Add(Point Px, Point Py)
        {
            //Point Result = new Point();
            //Result._xCord = Px._xCord + Py._xCord;
            //Result._yCord = Px._yCord + Py._yCord;

            //return Result;

            return new Point(Px._xCord + Py.XCord, Px._yCord + Py._yCord);

        }

        //Operator Overloading 
        public static Point operator + (Point Px, Point Py)
        {
            return new Point(Px._xCord + Py.XCord, Px._yCord + Py._yCord);

        }

        public static Point operator -(Point Px, Point Py)
        {
            return new Point(Px._xCord - Py.XCord, Px._yCord - Py._yCord);

        }

        public static bool operator > (Point Px, Point Py)
        {
            return Px._xCord > Py._xCord;
        }


        public static bool operator <(Point Px, Point Py)
        {
            return Px._xCord < Py._xCord;
        }

        public static bool operator <=(Point Px, Point Py)
        {
            return Px._xCord <= Py._xCord;
        }
        public static bool operator >=(Point Px, Point Py)
        {
            return Px._xCord >= Py._xCord;
        }

        public static Point operator +(Point Px, int no)
        {
            return new Point(Px._xCord + no);
        }
        public static Point operator +( int no, Point Px)
        {
            return new Point(Px._xCord + no);
        }

        //Casting

        public static implicit operator Point(int x)
        {
            return new Point(x);
        }

        public static explicit operator int(Point Px)
        {
            return Px._xCord;
        }


       
    }



}
