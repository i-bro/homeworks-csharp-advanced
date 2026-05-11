

namespace task3.model
{
    public class Circle : Shape
    {
        public double Radius {get; set;}
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculatePerimetar()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
