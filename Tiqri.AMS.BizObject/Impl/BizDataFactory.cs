using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.DataAccessObject;

namespace Tiqri.AMS.BizObject.Impl
{
    public class BizDataFactory : IDisposable
    {

        IDbContextFactory contextFactory;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IDbContextFactory Init()
        {
            return contextFactory ?? (contextFactory = new DbContextFactory());
        }
    }
}
