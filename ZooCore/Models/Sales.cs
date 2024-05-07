namespace ZooCore.Models;

public class Sales : BaseModel
{
    public void Saless(List<Zooshop> orders,List<Zooshop> salees ,string productName)
    {
        int counta = 0;
        int a = 0;
        foreach (var order in orders)
        {
            if(productName == order.Name)
            {
                counta++;
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
                        a = order.Count;
                        order.Count = count;
                        order.SalesDated = SalesDated;
                        salees.Add(order);
                    }
                    order.Count = a - count;
               }
            }
        }
        if(counta > 0) 
        {
            Console.WriteLine("Ugurlu gunler");
            Console.WriteLine("sizin varligininz bize xosbextlik verir");
        }
        else
        {
            Console.WriteLine("Bele mehsulumuz yoxdur. Siz ilk once olan mehsullara baxsaz yaxsi olar idiot:");
        }
    }
    public void GetSales(List<Zooshop> salees)
    {
        if (salees == null) Console.WriteLine("Hecbir mehsul Yoxdur");
        foreach (var item in salees)
        {
            Console.WriteLine($"{item.Id},Name: {item.Name},Count: {item.Count}, Time: {item.SalesDated}");
        }

    }
}
