namespace Domain;
public class User : IEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FullName { get { 
        return FirstName + " " + LastName;
        }}
    public string? FullNameLastFirst { get { 
        return LastName + ", " + FirstName;
        }}

    public DateTime CreatedDttm { get; }

    private Guid? Id;

    public User()
    {
        this.Id = Guid.NewGuid();
        this.CreatedDttm = DateTime.UtcNow;
    }

    public string GetFullNameFirstLast()
    {
        return FirstName + " " + LastName;
    }
    
    public string GetFullNameLastFirst()
    {
        return LastName + ", " + FirstName;
    }

    public Guid? GetId()
    {
        return Id;
    }
}