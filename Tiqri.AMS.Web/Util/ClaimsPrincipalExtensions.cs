using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace Tiqri.AMS.Web.Util
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal principal)
        {
            if (principal == null)
            {
                throw new ArgumentNullException(nameof(principal));
            }
            var claim = principal.FindFirst(ClaimTypes.NameIdentifier);
            return claim != null ? claim.Value : null;
        }
    }
}