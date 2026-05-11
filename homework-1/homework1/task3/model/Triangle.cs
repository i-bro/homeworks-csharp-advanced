using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.model
{
    public class Triangle : Shape
    {
        public double Base {get; set;}
        public double Height {get; set;}

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public override double CalculatePerimetar()
        {
            double hypotenuse = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Height, 2));
            return Base + Height + hypotenuse;
        }
    }
}
