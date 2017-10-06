using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tiqri.AMS.Web.ContextHandlers;
using Tiqri.AMS.Web.ViewModel;

namespace Tiqri.AMS.Web.Controllers.WebAPI
{
    public class AccidentController : ApiController
    {
        IAccidentContextHandler _accidentContextHandler;
        IEmployeeContextHandler _employeeContextHandler;
       public AccidentController(IAccidentContextHandler accidentContextHandler, IEmployeeContextHandler employeeContextHandler)
        {
            this._accidentContextHandler = accidentContextHandler;
            this._employeeContextHandler = employeeContextHandler;
        }
        // POST: api/Accident

        public IHttpActionResult Post(Accident accident)
        {
            accident.ReportedId = this._employeeContextHandler.GetEmployee(User.Identity.Name).UserID;
            return Ok(_accidentContextHandler.CreateAccident(accident));
        }

        public IHttpActionResult Get()
        {
            return Ok(_accidentContextHandler.QueryAccident());
        }
       
    }

}
