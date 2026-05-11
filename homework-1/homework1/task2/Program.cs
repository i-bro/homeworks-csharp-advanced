// See https://aka.ms/new-console-template for more information
using task2.interfaces;
using task2.model;

Console.WriteLine("Hello, World!");

Rectangle rect = new Rectangle(0.5, 10.0);
Circle circ = new Circle(3.0);
Triangle tri = new Triangle(4.0, 6.0);

List<IShape> shapes = new List<IShape> {rect, circ, tri};

foreach(var shape in shapes)
{
    Console.WriteLine($"{shape.GetType().Name} Area: {shape.GetArea():F2}");
}

