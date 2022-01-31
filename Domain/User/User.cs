namespace Domain;
public class User
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FullName { get { 
        return FirstName + " " + LastName;
        }}
    public string? FullNameLastFirst { get { 
        return LastName + ", " + FirstName;
        }}
    //int? Age { get; set; }
    public string? Id { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }

    public string GetFullNameFirstLast()
    {
        return FirstName + " " + LastName;
    }
    
    public string GetFullNameLastFirst()
    {
        return LastName + ", " + FirstName;
    }
}