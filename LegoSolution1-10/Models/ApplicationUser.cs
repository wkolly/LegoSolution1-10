using Microsoft.AspNetCore.Identity;

namespace LegoSolution1_10.Models;

public class ApplicationUser : IdentityUser
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    
}