namespace Taller02ED.Core
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        public Circle(string name, double r)
        {
            R = ValidateR(r);
            Name = "Circle";
        }

        public override double GetArea()
        {
            return Math.PI * R * R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        private double ValidateR(double value)
        {
            if (value <= 0)
                throw new Exception($"The radius: {value}, is not valid.");
            return value;
        }

    }
}

