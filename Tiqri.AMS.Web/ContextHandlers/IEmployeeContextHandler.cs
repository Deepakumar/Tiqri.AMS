using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.Web.ViewModel;

namespace Tiqri.AMS.Web.ContextHandlers
{
    public interface IEmployeeContextHandler
    {
        List<Employee> GelAllEmployee();

        CurrentUser GetEmployee(string name);
    }

    
}
