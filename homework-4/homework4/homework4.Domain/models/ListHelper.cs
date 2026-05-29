namespace homework4.Domain.models
{
    public static class ListHelper
    {
        public static void PrintSimple<T>(this List<T> list)
        {
            Console.WriteLine($"Printing {list.Count} items");
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        
        public static void PrintEntities(this List<Car> list) 
        {
            Console.WriteLine($"Printing {list.Count} items");
            foreach (Car item in list)
            {
                Console.WriteLine($"{item.Model} {item.MilesPerGalon} {item.AccelerationTime} {item.Cylinders} {item.HorsePower} {item.Origin} {item.Weight} ");
            }
        }
    }
}
