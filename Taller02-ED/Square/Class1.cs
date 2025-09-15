namespace Geometry
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        public override double GetArea() => A * A;

        public override double GetPerimeter() => 4 * A;

        private double ValidateA(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"The side: {value}, is not valid.");
            }
            return value;
        }
    }
}
