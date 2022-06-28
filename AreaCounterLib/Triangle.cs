using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCounterLib
{
    public class Triangle : Shape
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public bool IsRightTriangle { get; }
        public Triangle(double a, double b, double c)
        {
            if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentOutOfRangeException("Треугольник не может иметь данные стороны");

            FirstSide = a;
            SecondSide = b;
            ThirdSide = c;

            var sideOrded = new List<double>() { a, b, c }.OrderByDescending(x => x).ToList();
            IsRightTriangle = ((sideOrded[0] * sideOrded[0]) == (sideOrded[1] * sideOrded[1] + sideOrded[2] * sideOrded[2]));
        }
        public override double GetArea()
        {
            var halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) * (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));
        }
    }
}
