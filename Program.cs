using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SafeVault Demo ===");
        var db = new Database();
        db.Initialize();

        var service = new UserService(db);

        Console.Write("Enter username: ");
        var username = Console.ReadLine();

        Console.Write("Enter password: ");
        var password = Console.ReadLine();

        if (service.Login(username, password))
        {
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Login failed.");
        }
    }
}
