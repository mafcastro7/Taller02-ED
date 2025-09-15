using System;

namespace Taller02ED.Core
{
    public class Rectangle : Square
    {
        private double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = ValidateB(b);
            Name = "Rectangle";
        }

        public override double GetArea()
        {
            return A * B;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }

        private double ValidateB(double value)
        {
            if (value <= 0)
                throw new Exception($"The side B: {value}, is not valid.");
            return value;
        }
    }
}

