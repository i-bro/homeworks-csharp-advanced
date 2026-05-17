// See https://aka.ms/new-console-template for more information
using ClassLibrary2Task2.Domain.models;
using System.Runtime.ConstrainedExecution;

List<Vehicle> garage = new List<Vehicle>
        {
            new Car(),
            new MotorBike(),
            new Boat(),
            new Airplane()
        };

foreach (var vehicle in garage)
{
    vehicle.DisplayInfo();
}
    
