// See https://aka.ms/new-console-template for more information
using task3.model;

Console.WriteLine("Hello, World!");


Circle myCircle = new Circle(5);
Triangle myTri = new Triangle(3, 4);

Console.WriteLine($"Area of circle: {myCircle.CalculateArea()}");
Console.WriteLine($"Perimetar of circle: {myCircle.CalculatePerimetar()}");
Console.WriteLine($"Area of triangle: {myTri.CalculateArea()}");
Console.WriteLine($"Perimetar of triangle: {myTri.CalculatePerimetar()}");
