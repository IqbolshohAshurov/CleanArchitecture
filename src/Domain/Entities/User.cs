namespace Domain.Entities;

public class User
{
    public Guid UserId { get; set; }  // = Guid.NewGuid;
    
    public string UserName { get; set; }  // = null!
    
    //public string Email { get; set; }  // = null!
    
    public string Password { get; set; }  // = null!
    
    public string Role { get; set; }  // = null!
}