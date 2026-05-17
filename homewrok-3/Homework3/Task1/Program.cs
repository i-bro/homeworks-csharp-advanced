// See https://aka.ms/new-console-template for more information

using ClassLibrary1Task1.Domain.models;

Console.WriteLine("Hello, World!");
int num = 5;
string dog = "lusy";
List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

PrintInConsole.Print(num);
PrintInConsole.Print(dog);

PrintInConsole.PrintCollection(names);
PrintInConsole.PrintCollection(numbers);
