using Microsoft.AspNet.Identity;

namespace Real_Estate_Website.Identity
{
    public class AppUserManger : UserManager<AppUser>
    {
        public AppUserManger(IUserStore<AppUser> store) : base(store) { }
    }
}