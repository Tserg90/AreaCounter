using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCounterLib
{
    public class Circle : Shape
    {
        public double Radios { get; }
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");

            Radios = radius;
        }
        public override double GetArea() => Radios * Radios * Math.PI;
    }
}
