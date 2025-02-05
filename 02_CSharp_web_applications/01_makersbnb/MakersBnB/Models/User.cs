namespace MakersBnB.Models;
using System.ComponentModel.DataAnnotations;

public class User
{
  // some fields
  // the ? indicates that a field can be null / blank (is nullable)
  // {get; set;} tells the compiler to create getter and setter methods
    // the primary key is Id
    [Key]
    public int Id {get; set;}
    public string? UserName {get; set;}
    public string? Email {get; set;}
    public string? Password {get; set;}
    public User(string userName, string eMail, string password)
    {
        this.UserName = userName;
        this.Password = password;
        this.Email = eMail;
    }
    public User() {}
}