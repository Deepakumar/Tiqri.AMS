using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.Common;
using Tiqri.AMS.Web.ViewModel;

namespace Tiqri.AMS.Web.ContextHandlers
{
    public interface IAccidentContextHandler
    {
        ServiceTransObject<string> CreateAccident(ViewModel.Accident accident);

        List<AccidentTableData> QueryAccident();
    }
}
