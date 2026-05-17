namespace ClassLibrary2Task2.Domain.models
{
    public static class VehicleExtensions
    {
        public static void Drive(this Car car)
        {
            Console.WriteLine("Im a car and i drive on 4 wheels");
        }
        public static void Wheelie(this MotorBike moto)
        {
            Console.WriteLine("Im a motorbike and i drive on 2 wheels");
        }
        public static void Sail(this Boat boat)
        {
            Console.WriteLine("Im a boat and i do not have wheels");
        }
        public static void Fly(this Airplane plane)
        {
            Console.WriteLine("Im a plane i have couple of wheels");
        }
    }
}
