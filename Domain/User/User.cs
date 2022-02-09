using Domain.Exceptions;

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
    public string? Email { get; set; }

    public DateTime CreatedDttm { get; }

    private Guid? Id;

    public User(string FirstName, string LastName, string Email)
    {
        this.Id = Guid.NewGuid();
        this.CreatedDttm = DateTime.UtcNow;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Email = Email;
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

    public void Validate()
    {
        // Validate first name.
        if (this.FirstName == null)
        {
            throw new NotFoundException("User first name is null.");
        }

        // Validate last name.
        else if (this.LastName == null)
        {
            throw new NotFoundException("User last name is null.");
        }

        // Validate email.
        else if (this.Email == null)
        {
            throw new NotFoundException("User email is null.");
        }
    }
}