using Microsoft.AspNet.Identity.EntityFramework;
namespace Real_Estate_Website.Identity
{
    public class IdentityDB : IdentityDbContext<AppUser>
    {
        public IdentityDB() : base("name=MyDB") { }
    }
}