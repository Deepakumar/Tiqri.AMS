using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tiqri.AMS.Web.ContextHandlers;

namespace Tiqri.AMS.Web.Controllers.WebAPI
{
    [RoutePrefix("api/currentUser")]
    public class CurrentUserController : ApiController
    {
        IEmployeeContextHandler _employeeContextHandler;
        public CurrentUserController(IEmployeeContextHandler employeeContextHandler)
        {
            _employeeContextHandler = employeeContextHandler;
        }
        // GET: api/CurrentUser
        public IHttpActionResult Get()
        {
            return Ok(this._employeeContextHandler.GetEmployee(User.Identity.Name));
        }

    }
}
