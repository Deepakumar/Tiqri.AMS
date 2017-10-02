using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiqri.AMS.DataAccessObject
{
    public class DbContextFactory : IDbContextFactory
    {
        AmsDbContext dbContext;

        public AmsDbContext Init()
        {
            return dbContext ?? (dbContext = new AmsDbContext());
        }

    }
}
