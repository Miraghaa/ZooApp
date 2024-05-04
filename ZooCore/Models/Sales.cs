namespace ZooCore.Models;

public class Sales : BaseModel
{
    public void Saless(List<Zooshop> orders, string productName)
    {
        foreach (var order in orders)
        {
            if(productName == order.Name)
            {
               if(order.Count == 0)
               {
                    Console.WriteLine("Hal hazirda satis ede bilmiriy");
               }
               else
               {
                    Console.WriteLine($"nece eded isteyirsiz bizde olan {order.Count}");
                    int count = int.Parse(Console.ReadLine());
                    if (count > order.Count) Console.WriteLine($"Size dediy axi bizde olan {order.Count}");
                    else
                    {
                        int a = order.Count - count;
                        order.Count = a;
                        Console.WriteLine("Ugurlu gunler");
                    }
               }
            }
            else
            {
                Console.WriteLine("Bele mehsulumuz yoxdur. Siz ilk once olan mehsullara baxsaz yaxsi olar idiot:");
            }
        }
    }
}
