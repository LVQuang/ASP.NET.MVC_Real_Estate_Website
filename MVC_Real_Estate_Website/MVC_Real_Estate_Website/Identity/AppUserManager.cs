using Microsoft.AspNet.Identity;

namespace Real_Estate_Website.Identity
{
    public class AppUserManager : UserManager<AppUser>
    {
        public AppUserManager(IUserStore<AppUser> store) : base(store) { }
    }
}