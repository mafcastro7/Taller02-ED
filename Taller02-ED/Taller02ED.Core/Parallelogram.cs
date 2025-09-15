using System;

namespace Taller02ED.Core
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = ValidateH(h);
        }

        public override double GetArea()
        {
            return B * H;
        }
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
        private double ValidateH(double value)
        {
            if (value <= 0)
                throw new Exception($"The height H: {value}, is not valid.");
            return value;
        }
    }
}
