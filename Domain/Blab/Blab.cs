using Domain.Exceptions;

namespace Domain;

public class Blab : IEntity
{
    public User? User { get; set; }
    public string? Content { get; set; }
    public DateTime CreatedDttm { get; }
    //public DateTime UPdatedDttm { get; }

    private Guid? Id { get; set; }  

    public Blab(string message, User user)
    {
        this.Content = message;
        this.Id = Guid.NewGuid();
        this.CreatedDttm = DateTime.UtcNow;
        this.User = user;
    }

    public Guid? GetId()
    {
        return Id;
    }

    public void Validate()
    {
        // Check to see if content exists.
        if (this.Content == null)
        {
            throw new NotFoundException("Content is null.");
        }

        // Check to see if user exists.
        else if (this.User == null)
        {
            throw new NotFoundException("User is null.");
        }
    }

}
