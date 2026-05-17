namespace ClassLibrary1Task1.Domain.models
{
    public static class PrintInConsole
    {
        public static void Print<T>(T item)
        {
            Console.WriteLine($"Single item: {item}");
        }
        public static void PrintCollection<T>(IEnumerable<T> collection)
        {
            Console.WriteLine("Collection start");
            foreach (var item in collection)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Collection end");
        }
    }
}
