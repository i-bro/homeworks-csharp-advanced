

namespace ClassLibrary2Task2.Domain.models
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is a Car. It travels on roads and usually has 4 wheels.");
        }
    }
}
