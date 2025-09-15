using System;

namespace Taller02ED.Core
{
    public class Trapeze : Triangle
    {
        private double _d;

        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }
        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = ValidateD(d);
        }

        public override double GetArea()
        {
            return ((B + D) * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }

        private double ValidateD(double value)
        {
            if (value <= 0)
                throw new Exception($"The side D: {value}, is not valid.");
            return value;
        }
    }
}

