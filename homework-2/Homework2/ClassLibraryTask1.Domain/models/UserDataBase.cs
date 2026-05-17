

namespace ClassLibraryTask1.Domain.models
{
    public static class UserDataBase
    {
        public static List<User> users = new List<User>();
        
        static UserDataBase()
        {
            users.Add(new User(1, "Alice", 28));
            users.Add(new User(2, "Bob", 35));
            users.Add(new User(3, "Charlie", 22));
            users.Add(new User(4, "Alice", 19));
            users.Add(new User(5, "John", 28));
            users.Add(new User(6, "Ema", 30));
        }
        public static List<User> Search(string name)
        {
            return users.Where(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public static List<User> Search(int age)
        {
            return users.Where(u => u.Age == age).ToList();
        }
        public static List<User> SearchById(int id)
        {
            return users.Where(u => u.Id == id).ToList();
        }
        public static void DisplayResults(List<User> users)
        {
            Console.WriteLine("\n--- Search Results ---");

            if (users == null || users.Count == 0)
            {
                Console.WriteLine("No users found matching those criteria.");
                return;
            }

            foreach (User user in users)
            {
                Console.WriteLine(user.DisplayUsers());
            }
        }
    }
}
