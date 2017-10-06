using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.DataAccessObject.Repository.Impl
{
    public class AccidentRepository : RepositoryBase<Accident> ,  IAccidentRepository
    {
        AmsDbContext dbContext;
        public AccidentRepository()
        {
            dbContext = new AmsDbContext();
        }
        public AccidentRepository(AmsDbContext dbContext)
        {

        }
        public int GetNextSequenceValue()
        {
            var rawQuery = dbContext.Database.SqlQuery<int>("SELECT NEXT VALUE FOR RefSequence;");
            var task = rawQuery.SingleAsync();
            int nextVal = task.Result;
            return nextVal;
        }

        public int InsertAccident(Accident accident)
        {
            accident.ReferenceNo = "ACC" + GetNextSequenceValue();
            return Save(accident);
        }

        public List<Accident> QueryAccident()
        {
            return GetAll().ToList<Accident>();
        }
    }
}
