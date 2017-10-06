using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.DataAccessObject.Repository;

namespace Tiqri.AMS.DataAccessObject
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        
        private AmsDbContext context;
        private IAccidentCategoryRepository _accidentCategoryRepository;

        public UnitOfWork()
        {
            this.context = new AmsDbContext();
        }

        public UnitOfWork(AmsDbContext context)
        {
            this.context = context;
        }

        public IAccidentCategoryRepository AccidentCategoryRepository
        {
            get
            {

                if (this._accidentCategoryRepository == null)
                {
                    this._accidentCategoryRepository = new AccidentCategoryRepository(context);
                }
                return _accidentCategoryRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
