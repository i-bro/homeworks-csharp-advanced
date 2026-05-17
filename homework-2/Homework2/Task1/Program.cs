// See https://aka.ms/new-console-template for more information
using ClassLibraryTask1.Domain.models;

while (true)
{
    Console.WriteLine("\nChoose Search: \n1-Name, \n2-Age, \n3-ID, \n4-Exit");
    string choise = Console.ReadLine();

    List<User> foundUsers = new List<User>();

    if(choise == "1")
    {
        Console.WriteLine("Enter Name:");
        string input = Console.ReadLine();
        foundUsers = UserDataBase.Search(input);
    }
    else if(choise == "2")
    {
        Console.WriteLine("Enter Age:");
        if(int.TryParse(Console.ReadLine(), out int age));
        foundUsers = UserDataBase.Search(age);
    }
    else if(choise == "3")
    {
        Console.WriteLine("Enter ID:");
        if(int.TryParse(Console.ReadLine(), out int id));
        foundUsers = UserDataBase.SearchById(id);
    }
    else if(choise == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Enter a valid choise");
    }

    
    UserDataBase.DisplayResults(foundUsers);
}
