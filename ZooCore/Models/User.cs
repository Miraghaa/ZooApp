using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooCore.Enum;

namespace ZooCore.Models;

public class User : BaseModel
{
    public string UserName { get; set; } = null!;
    public string SurName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Role { get; set; } = null!;


    public User()
    {
        Id = Guid.NewGuid().ToString();
    }
    public void Login(User user)
    {
        Console.WriteLine("Username");
        string userName = Console.ReadLine();
        Console.WriteLine("Password");
        string password = Console.ReadLine();
        if (user.UserName == userName && user.Password == password)
        {
            Console.WriteLine($"Daxil oldunuz {user.Role}");
        }
        else Console.WriteLine("daxil ola bilmediz");
    }
    public User Register(User user)
    {
        bool isValidPassword = false;
        Console.WriteLine("Username write");
        user.UserName = Console.ReadLine();
        Console.WriteLine("SurName write");
        user.SurName = Console.ReadLine();
        Console.WriteLine("Password");
        while (!isValidPassword)
        {
            Console.WriteLine("Password (1 boyu 1 kicik 8 uzun):");
            user.Password = Console.ReadLine();

            isValidPassword = true;

            if (user.Password.Length < 8 || !user.Password.Any(char.IsLower) || !user.Password.Any(char.IsUpper))
            {
                Console.WriteLine("olmadi yeniden");
                isValidPassword = false;
            }
        }
        Console.WriteLine("Select role:");
        Console.WriteLine("1. Admin");
        Console.WriteLine("2. Moderator");
        Console.WriteLine("3. User");

        int choice = int.Parse(Console.ReadLine());
            // Seçimə görə uyğun rol təyin edilir
            switch (choice)
            {
                case 1:
                    user.Role = Roles.Admin.ToString();
                    break;
                case 2:
                    user.Role = Roles.Moderator.ToString();
                    break;
                case 3:
                    user.Role = Roles.User.ToString();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        return user;
    }


}


