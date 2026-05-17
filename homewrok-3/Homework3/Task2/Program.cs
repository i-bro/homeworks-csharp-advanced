// See https://aka.ms/new-console-template for more information

using ClassLibrary2Task2.Domain.models;
Console.WriteLine("Hello, World!");
Car car = new Car();
MotorBike motorBike = new MotorBike();
Boat boat = new Boat();
Airplane plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

car.Drive();
motorBike.Wheelie();
boat.Sail();
plane.Fly();

