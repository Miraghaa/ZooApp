using ZooCore.Models;
List<User> users = new List<User>();
List<Zooshop> zooshops = new List<Zooshop>();
Sales sales = new Sales();
Register:
Console.WriteLine("Xos gelmissiniz ilk once qeydiyatdan kecey");
User user = new User();
users.Add(user.Register(user));
Console.WriteLine("Qeydiyatdan kecdiniz");
Login:
Console.WriteLine("Siz hansisiz");
Console.WriteLine("1. Admin");
Console.WriteLine("2. Moderator");
Console.WriteLine("3. User");
Console.WriteLine("Once bir daxil olun");
Console.WriteLine("Username");
string userName = Console.ReadLine();
Console.WriteLine("Password");
string password = Console.ReadLine();
if (user.UserName == userName && user.Password == password)
{
    Console.WriteLine($"Daxil oldunuz {user.Role}");
    switch (user.Role)
    {
        case "Admin":
        Start:
            Console.WriteLine("0 .Exit App");
            Console.WriteLine("1. mehsul yaradin");
            Console.WriteLine("2. mehsullara baxin");
            Console.WriteLine("3. Mehsulu silin");
            Console.WriteLine("4. Idye gore baxin");
            Console.WriteLine("5. Register menyusu");
            Console.WriteLine("6. Login menyusu");
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                Zooshop zooshop = new Zooshop();
                switch (a)
                {
                    case 1:
                        zooshops.Add(zooshop.Create(zooshop));
                        break;
                    case 2:
                        zooshop.GetAll(zooshops);
                        break;
                    case 3:
                        Console.WriteLine("Id girin");
                        string? tempId = Console.ReadLine();
                        zooshop.Deleted(zooshops, tempId);
                        break;
                    case 4:
                        Console.WriteLine("Id girin");
                        string tempId2 = Console.ReadLine();
                        zooshop.FindById(zooshops, tempId2);
                        break;
                    case 5:
                        goto Register;
                    case 6:
                        goto Login;
                    default:
                        Console.WriteLine("Sagol");
                        break;

                }
                goto Start;
            }
            break;
        case "User":
        Start2:
            Console.WriteLine("0 .Exit App");
            Console.WriteLine("1. Mehsullara baxin");
            Console.WriteLine("2. Mehsul alin");
            Console.WriteLine("3. Register menyusu");
            Console.WriteLine("4. Login menyusu");
            a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                Zooshop zooshop = new Zooshop();
                switch (a)
                {
                    case 1:
                        zooshop.GetAll(zooshops);
                        break;
                    case 2:
                        Console.WriteLine("Mehsulun adini yazin");
                        string productName = Console.ReadLine();
                        sales.Saless(zooshops, productName);
                        break;
                    case 3:
                        goto Register;
                    case 4:
                        goto Login;
                    default:
                        Console.WriteLine("Sagol");
                        break;

                }
                goto Start2;
            }
            break;
        default:
            Console.WriteLine("Sagol");
            break;
    }

}
else Console.WriteLine("Yalnis username veya sifre");
Console.WriteLine("Register kecmey isteyirsiz? true veya false yazin.hahaha");
bool yoxlama = bool.Parse(Console.ReadLine());
if (yoxlama) goto Register;
goto Login;





