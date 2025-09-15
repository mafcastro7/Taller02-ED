using System;

namespace Taller02ED.Core
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = ValidateC(c);
            H = ValidateH(h);
        }

        public override double GetArea()
        {
            return (B * H) / 2.0;
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }

        private double ValidateC(double value)
        {
            if (value <= 0)
                throw new Exception($"The side C: {value}, is not valid.");
            return value;
        }

        private double ValidateH(double value)
        {
            if (value <= 0)
                throw new Exception($"The height H: {value}, is not valid.");
            return value;
        }
    }
}

