using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Tiqri.AMS.BizObject;
using Tiqri.AMS.BizObject.Impl;
using Tiqri.AMS.Common;
using Tiqri.AMS.Model.Enum;
using Tiqri.AMS.Web.App_Start;
using Tiqri.AMS.Web.ViewModel;

namespace Tiqri.AMS.Web.ContextHandlers.impl
{
    public class AccidentContextHandler : IAccidentContextHandler
    {
        IAccidentBiz _accidentBiz;

        List<Models.ApplicationUser> usersList;

        public AccidentContextHandler()
        {
            _accidentBiz = new AccidentBiz();
        }
        public AccidentContextHandler(IAccidentBiz accidentBiz)
        {
            this._accidentBiz = accidentBiz;
        }

        public ServiceTransObject<string> CreateAccident(Accident accident)
        {
            ServiceTransObject<string> result = new ServiceTransObject<string>();
            Model.Accident modelAccident = new Model.Accident();
            modelAccident.ReporterID = accident.ReportedId;
            modelAccident.ActionCategoryID = accident.CategoryId;
            modelAccident.TypeOfLocation =(TypeOfLocation) accident.LocationTypeId;
            modelAccident.History = accident.History;
            string dateTimeStr = String.Format("{0} {1}", accident.Date, accident.Time);
            modelAccident.AccidentDate = DateTime.ParseExact(dateTimeStr, "dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture);
            modelAccident.Status = AccidentStatus.New;
            if(_accidentBiz.CreateAccident(modelAccident))
            {
                result.ResponseStatus = true;
                result.Result = modelAccident.ReferenceNo;
                result.Message = String.Format(App_LocalResources.Accident.Sucessfull, modelAccident.ReferenceNo);
            }
            return result;
        }

        public List<AccidentTableData> QueryAccident()
        {
            List<AccidentTableData> accidents=null;

            var accidentList = this._accidentBiz.QueryAccident();
            if(accidentList != null && accidentList.Count > 0)
            {
                accidents = new List<AccidentTableData>();

                foreach (var item in accidentList)
                {
                    accidents.Add(new AccidentTableData()
                    {
                        AccidentID = item.ID.HasValue ? item.ID.Value : 0,
                        AccidentRefNo = !String.IsNullOrEmpty(item.ReferenceNo) ? item.ReferenceNo : "",
                        Date = item.AccidentDate.Year > 1900 ? item.AccidentDate.ToShortTimeString() : "",
                        Location = item.TypeOfLocation,
                       // Reporter = GetUserName(item.ReporterID)
                        
                    });
                }
            }

            return accidents;
        }

        private string GetUserName(string userId)
        {
            if(usersList == null)
            {
                usersList = HttpContext.Current.GetOwinContext().Get<AuthContext>().Users.ToList();
            }

            var user = usersList.Where(u => u.Id == userId).First();

            return String.Format("{0} {1}", user.FirstName, user.LastName);
        }
    }
}