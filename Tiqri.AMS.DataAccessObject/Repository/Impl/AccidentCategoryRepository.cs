using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.DataAccessObject.Repository
{
    public class AccidentCategoryRepository : RepositoryBase<AccidentCategory>, IAccidentCategoryRepository
    {
        AmsDbContext dbContext;
        public AccidentCategoryRepository()
        {
            dbContext = new AmsDbContext();
        }
        public AccidentCategoryRepository(AmsDbContext dbContext) 
        {
            
        }

        public List<AccidentCategory> GetAccidentCategoryList()
        {
            return GetAll().ToList();
        }
    }
}
