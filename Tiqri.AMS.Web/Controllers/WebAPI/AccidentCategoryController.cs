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
    public class AccidentCategoryController : ApiController
    {
        IAccidentTypeContextHandler accidentTypeContextHandler;
        public AccidentCategoryController(IAccidentTypeContextHandler accidentTypeContextHandler)
        {
            this.accidentTypeContextHandler = accidentTypeContextHandler;
        }

        [Authorize]
        // GET: api/AccidentCategory
        public IHttpActionResult Get()
        {
            return Ok(accidentTypeContextHandler.GetAccidentCategoryList());
        }

    }
}
