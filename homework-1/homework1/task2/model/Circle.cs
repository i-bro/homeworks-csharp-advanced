

using task2.interfaces;

namespace task2.model
{
    public class Circle : IShape
    {
        public double Radius {get; set;}

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
