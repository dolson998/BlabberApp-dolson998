namespace Domain;

public class Blab : IEntity
{
    public string? Contetn { get; set; }
    public DateTime CreatedDttm { get; }
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
