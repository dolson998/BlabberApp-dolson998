namespace Domain;

public class Blab : IEntity
{
    public string? Content { get; set; }
    public DateTime CreatedDttm { get; }
    //public DateTime UPdatedDttm { get; }

    private Guid? Id;

    public Blab(string message, User user)
    {
        this.Id = Guid.NewGuid();
        this.CreatedDttm = DateTime.UtcNow;
    }

    public Guid? GetId()
    {
        return Id;
    }

}
