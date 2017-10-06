using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.BizObject.Impl
{
    public interface IAccidentBiz
    {
        bool CreateAccident(Accident accident);

        List<Accident> QueryAccident();
    }
}
