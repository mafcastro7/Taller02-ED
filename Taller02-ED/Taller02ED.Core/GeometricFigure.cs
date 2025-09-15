namespace Taller02ED.Core
{
    public abstract class GeometricFigure
    {
        public string? Name { get; protected set; }
        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name,-15} => Area.....: {GetArea(),8:F5}   Perimeter: {GetPerimeter(),8:F5}";
        }
    }
}