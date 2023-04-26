using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Classwork
{
    internal class Triangle : FigureClass
    {
        private double a;
        private double h;
        private double b;
        private double c;

        public Triangle(double a, double h, double b, double c) : base("треугольника")
        {
            this.a = a;
            this.h = h;
            this.b = b;
            this.c = c;
        }

        public override double GetPerimeter()
        {
            return a + b + c;
        }
        public override double GetArea()
        {
            var p = GetPerimeter() / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 3);
        }
    }
}
