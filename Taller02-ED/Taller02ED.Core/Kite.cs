using System;

namespace Taller02ED.Core
{
    public class Kite : Rhombus
    {
        private double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
        {
            B = ValidateB(b);
        }

        public override double GetPerimeter()
        {
            return 2 * (A + D2);
        }

        public override double GetArea()
        {
            return (D1 * B) / 2.0;
        }

        private double ValidateB(double value)
        {
            if (value <= 0)
                throw new Exception($"The side B: {value}, is not valid.");
            return value;
        }
    }
}
