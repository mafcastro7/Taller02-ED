using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller02ED.Core
{
    public class Square : GeometricFigure
    {
        private double _a;
        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        public Square(string name, double a)
        {
            A = ValidateA(a);
            Name = "Square";
        }

        public override double GetArea()
        {
            return A * A;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }

        private double ValidateA(double value)
        {
            if (value <= 0)
                throw new Exception($"The side: {value}, is not valid.");
            return value;
        }

    }
}
