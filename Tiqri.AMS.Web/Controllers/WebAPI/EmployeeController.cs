using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tiqri.AMS.Web.ContextHandlers;
using Tiqri.AMS.Web.Util;

namespace Tiqri.AMS.Web.Controllers.WebAPI
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        IEmployeeContextHandler _contextHandler;
        public EmployeeController(IEmployeeContextHandler employeeContextHandler)
        {
            this._contextHandler = employeeContextHandler;
        }
        // GET: api/Employee
        public IHttpActionResult Get()
        {
            return Ok(this._contextHandler.GelAllEmployee());
        }


        public IHttpActionResult Get(int id)
        {
            return Ok(this._contextHandler.GetEmployee(User.Identity.Name));
        }

    }
}
