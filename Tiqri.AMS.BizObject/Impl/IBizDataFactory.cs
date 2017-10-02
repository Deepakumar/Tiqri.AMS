using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.DataAccessObject;

namespace Tiqri.AMS.BizObject.Impl
{
    public interface IBizDataFactory
    {
        IDbContextFactory Init();
    }
}
