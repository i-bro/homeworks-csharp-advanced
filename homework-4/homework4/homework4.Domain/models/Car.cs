namespace homework4.Domain.models
{
    public class Car
    {
        public string Model {get; set;}
        public double MilesPerGalon {get; set;}
        public int Cylinders {get; set;}
        public double HorsePower {get; set;}
        public double Weight {get; set;}
        public double AccelerationTime {get; set;}
        public string Origin {get; set;}
        public Car() {}
        public Car(string model, double milesPerGalon, int cylinders, double horsePowres, double weight, double accelerationTime, string origin)
        {
            Model = model;
            MilesPerGalon = milesPerGalon;
            Cylinders = cylinders;
            HorsePower = horsePowres;
            Weight = weight;
            AccelerationTime = accelerationTime;
            Origin = origin;
        }

    }
}
