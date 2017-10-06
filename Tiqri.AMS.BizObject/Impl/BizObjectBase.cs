using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.Common;
using Tiqri.AMS.DataAccessObject.Interface;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.BizObject
{
    public abstract class BizObjectBase<T> : IBizObjectBase<T> where T : EntityBase
    {
        IRepository<T> _repository;

        public BizObjectBase() { }

        public BizObjectBase(IRepository<T> repository) { _repository = repository; }

        public BizTransObject<bool> Delete(int id)
        {
            BizTransObject<bool> transferObject = new BizTransObject<bool>(false, new StatusInfo());

            try
            {
                _repository.Delete(id);
                transferObject.StatusInfo.Status = ServiceStatus.Success;
            }
            catch (Exception)
            {
                transferObject.StatusInfo.Status = ServiceStatus.DatabaseFailer;
            }

            return transferObject;
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IList<T> GetAll(Expression<Func<T, bool>> whereCondition)
        {
            return _repository.GetAll(whereCondition);
        }

        public T GetSingle(int id)
        {
            T returnObject = null;

            try
            {
                returnObject = _repository.GetSingle(t => t.ID == id);
            }
            catch (Exception ex)
            {
            
            }

            return returnObject;
        }

        public BizTransObject<T> Save(T entry)
        {
            BizTransObject<T> transferObject = new BizTransObject<T>(entry, new StatusInfo());

            try
            {
                int status = _repository.Save(entry);
                transferObject.StatusInfo.Status = ServiceStatus.Success;

            }
            catch (Exception ex)
            {
                transferObject.StatusInfo.Status = ServiceStatus.DatabaseFailer;
                transferObject.StatusInfo.Message = ex.Message;
            }

            return transferObject;
        }
    }
}
