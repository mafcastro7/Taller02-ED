using Geometry;

namespace Geometry
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R
            {
            get => _r;
            set => _r = ValidateR(value);
        }

        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        public override double GetArea() => Math.PI * R * R;
        public override double GetPerimeter() => Math.PI * 2 * R;

        private double ValidateR(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"El radio: {value}, is not valid.");
            }
            return value;
        }
    }
}
