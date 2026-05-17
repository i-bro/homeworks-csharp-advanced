namespace ClassLibrary2Task2.Domain.models
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is a Boat. It navigates across bodies of water.");
        }
    }
}
