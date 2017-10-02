using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModel = Tiqri.AMS.Web.ViewModel;

namespace Tiqri.AMS.Web.ContextHandlers
{
    public interface IAccidentTypeContextHandler
    {
        List<ViewModel.AccidentCategory> GetAccidentCategoryList();
    }
}