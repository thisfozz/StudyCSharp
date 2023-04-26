using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Classwork
{
    internal abstract class FigureClass
    {
        private readonly string name;
        protected FigureClass(string name)
        {
            this.name = name;
        }
        public string GetFigureName()
        {
            return name;
        }
        abstract public double GetPerimeter();
        abstract public double GetArea();
    }
}
