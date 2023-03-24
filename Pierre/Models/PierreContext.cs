using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Pierre.Models
{
    public class PierreContext : IdentityDbContext<ApplicationUser>
    {

    }
}