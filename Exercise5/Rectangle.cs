using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Rectangle : Shape
    {
        public Rectangle(double height, double width) : base(height, width)
        {

        }

        public override double CalculateSurface()
        {
            return height * width;
        }
    }
}
