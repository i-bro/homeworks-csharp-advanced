using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.interfaces;

namespace task2.model
{
    public class Triangle : IShape
    {
        public double Base {get; set;}
        public double Height {get; set;}

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
        public double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
