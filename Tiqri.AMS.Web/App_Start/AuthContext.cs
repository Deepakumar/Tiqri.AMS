using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tiqri.AMS.Web.Models;

namespace Tiqri.AMS.Web.App_Start
{
    public class AuthContext : IdentityDbContext<ApplicationUser>
    {
        public AuthContext()
            : base("DefaultConnection")
        {

        }

        public static AuthContext Create()
        {
            return new AuthContext();
        }
    }
}