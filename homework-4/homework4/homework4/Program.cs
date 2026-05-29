// See https://aka.ms/new-console-template for more information
using homework4.Domain.dataBase;
using homework4.Domain.models;

Console.WriteLine("Hello, World!");

//* Filter all cars that have origin from Europe and print them in console.
List<Car> originFromEurope = CarsData.Cars.Where(x => x.Origin.ToLower() == "Europe".ToLower()).ToList();
//originFromEurope.PrintEntities();

//* Filter all cars that have more that 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result and print them in console.
List<Car> moreThan6Cilindars = CarsData.Cars.Where(x => x.Cylinders > 6  || x.Cylinders == 4 && x.HorsePower > 110.0).ToList();
//moreThan6Cilindars.PrintEntities();

//* Count all cars based on their Origin and print the result in console. Example outpur "US 10 models\n Eu 15 Models";
var groupedCars = CarsData.Cars.GroupBy(x => x.Origin);
foreach(var item in groupedCars)
{
    Console.WriteLine($"{item.Key} {item.Count()} Models");
}

//* Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highes and average Miles per galon and print them in console;
List<Car> moreThan200HorsePower = CarsData.Cars.Where(x => x.HorsePower > 200).ToList();
if(moreThan200HorsePower.Count > 0)
{
    double lowest = moreThan200HorsePower.Min(x => x.MilesPerGalon);
    double average = moreThan200HorsePower.Average(x => x.MilesPerGalon);
    double highes = moreThan200HorsePower.Max(x => x.MilesPerGalon);

    Console.WriteLine("--- Stats for Cars with > 200 HP ---");
    Console.WriteLine($"Lowest MPG: {lowest}");
    Console.WriteLine($"Average MPG: {average}");
    Console.WriteLine($"Highest MPG: {highes}");
}
else
{
    Console.WriteLine("No cars found with more than 200 HorsePower.");
}


// * // Add more examples

//Models of Heavy Cars (> 4000 lbs)
List<string> heavyCars = CarsData.Cars.Where(x => x.Weight > 4000).Select(x => x.Model).ToList();
heavyCars.PrintSimple();
