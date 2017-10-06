using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tiqri.AMS.Web.ViewModel
{
    public class CurrentUser
    {
        public string UserID { get; set; }
        public string TitleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}