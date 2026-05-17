namespace ClassLibrary2Task2.Domain.models
{
    public class Airplane : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is an Airplane. It flies through the skies at high speeds.");
        }
    }
}
