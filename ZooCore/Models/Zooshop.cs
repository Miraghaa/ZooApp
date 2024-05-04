namespace ZooCore.Models;

public class Zooshop : BaseModel
{
    public string Name { get; set; }
    public bool Stock {  get; set; } = false;
    public int Count { get; set; }
    public Zooshop() 
    {
        Id = Guid.NewGuid().ToString();
    }

    public Zooshop Create(Zooshop zooshop)
    {
        zooshop.Id = Id;
        Console.WriteLine("Mehsulun adi");
        zooshop.Name = Console.ReadLine();
        Console.WriteLine("Mehsulun sayi");
        zooshop.Count = int.Parse(Console.ReadLine());
        if (zooshop.Count > 0 )
        {
            zooshop.Stock = true;
        }
        return zooshop;
    }
    public void GetAll(List<Zooshop> zooshop)
    {
        if(zooshop == null) Console.WriteLine("Hecbir mehsul Yoxdur");
        foreach (var item in zooshop)
        {
            Console.WriteLine($"{item.Id},Name: {item.Name},Count: {item.Count}, Time: {item.CreatedDated}");
        }

    }
    public void FindById(List<Zooshop> zooshop, string id)
    {
        foreach (var item in zooshop)
        {
            if (item.Id == id)
            {
                Console.WriteLine($"{item.Id},Name: {item.Name},Count: {item.Count}, Time: {item.CreatedDated}");
            }
            else Console.WriteLine("Bele idli mehsul yoxdu");
        }
    }
    public void Deleted(List<Zooshop> zooshop, string id)
    {
        for (int i = 0; i < zooshop.Count; i++)
        {
            if (zooshop[i].Id == id)
            {
                zooshop.Remove(zooshop[i]);
                Console.WriteLine("silindi");
            }
            else Console.WriteLine("Bele idli mehsul yoxdu");
        }
    }
}
