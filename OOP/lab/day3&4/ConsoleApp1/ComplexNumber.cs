using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ComplexNumber
    {
        private double _real;
        private double _imaginary;
        public double Real
        {
            get { return _real; }
            set { _real = value; }
        }

        public double Imaginary
        {
            get { return _imaginary; }
            set { _imaginary = value; }
        }

        public ComplexNumber() : this(0, 0) { }

        public ComplexNumber(double real) : this(real, 0) { }

        public ComplexNumber(double real, double imaginary)
        {
            this._real = real;
            this._imaginary = imaginary;
        }        

        public double GetMagnitude()
        {
            return Math.Sqrt((_real * _real) + (_imaginary * _imaginary));
        }

        public static ComplexNumber operator + (ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1._real + c2._real, c1._imaginary + c2._imaginary);
        }

        public static ComplexNumber operator - (ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1._real - c2._real, c1._imaginary - c2._imaginary);
        }

        public static ComplexNumber operator * (ComplexNumber c1, ComplexNumber c2)
        {
            double realPart = (c1._real * c2._real) - (c1._imaginary * c2._imaginary);
            double imaginaryPart = (c1._real * c2._imaginary) + (c1._imaginary * c2._real);
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static ComplexNumber operator / (ComplexNumber c1, ComplexNumber c2)
        {
            double denominator = (c2._real * c2._real) + (c2._imaginary * c2._imaginary);
            if (denominator == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            double realPart = ((c1._real * c2._real) + (c1._imaginary * c2._imaginary)) / denominator;
            double imaginaryPart = ((c1._imaginary * c2._real) - (c1._real * c2._imaginary)) / denominator;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static bool operator >=(ComplexNumber c1, ComplexNumber c2)
        {
            return c1.GetMagnitude() >= c2.GetMagnitude();
        }

        public static bool operator <=(ComplexNumber c1, ComplexNumber c2)
        {
            return c1.GetMagnitude() <= c2.GetMagnitude();
        }

        public static ComplexNumber operator ++ (ComplexNumber c)
        {
            return new ComplexNumber(c._real + 1, c._imaginary + 1);
        }

        public static implicit operator ComplexNumber (double d)
        {
            return new ComplexNumber(d);
        }

        public static explicit operator double (ComplexNumber c)
        {
            if (c._imaginary != 0)
            {
                throw new InvalidCastException("Cannot convert complex number with non-zero imaginary part to double.");
            }
            return c._real;
        }

        public override string ToString()
        {
            return $"({_real},{_imaginary})";
        }
    }
}
