namespace ZooCore.Models;

public class BaseModel
{
    public string Id;
    public DateTime CreatedDated = DateTime.UtcNow.AddHours(4);
}
