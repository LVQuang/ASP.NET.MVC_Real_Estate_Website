using Microsoft.AspNet.Identity.EntityFramework;

namespace Real_Estate_Website.Identity
{
    public class AppUserStore : UserStore<AppUser>
    {
        public AppUserStore(IdentityDB context) : base(context) { }
    }
}