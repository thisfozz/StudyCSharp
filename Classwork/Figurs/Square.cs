using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Classwork
{
    internal class Square : FigureClass
    {
        private double a;
        public Square(double a) : base("квадрата")
        {
            this.a = a;
        }
        public override double GetPerimeter()
        {
            return a * 4;
        }

        public override double GetArea()
        {
            return a * a;
        }
    }
}
