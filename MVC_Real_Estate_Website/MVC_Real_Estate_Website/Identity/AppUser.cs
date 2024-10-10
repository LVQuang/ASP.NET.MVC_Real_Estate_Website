using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Real_Estate_Website.Identity
{
    public class AppUser : IdentityUser
    {
        public DateTime? Birtday { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}