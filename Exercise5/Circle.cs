using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Circle : Shape
    {
        public Circle(double radius)
        {
            width = radius;
            height = radius;
        }
        public override double CalculateSurface()
        {
            return Math.PI * width * height;
        }
    }
}
