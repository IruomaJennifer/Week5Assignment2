using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal abstract class Shape
    {
        public Shape()
        {

        }
        public Shape(double width,double height)
        {
            this.height = height;
            this.width = width;

        }
        public abstract double CalculateSurface();
        protected double width;
        protected double height;
    }
}
