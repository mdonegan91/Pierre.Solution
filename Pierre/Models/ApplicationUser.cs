using Microsoft.AspNetCore.Identity;

namespace Pierre.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string PierreId { get; }
  }
}