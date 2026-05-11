

using task2.interfaces;

namespace task2.model
{
    public class Rectangle : IShape
    {
        public double Length {get; set;}
        public double Width {get; set;}

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double GetArea()
        {
            return Length * Width;
        }
    }
}
