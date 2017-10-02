using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.Common;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.BizObject
{
    public interface IBizObjectBase<T> where T : EntityBase
    {
        T GetSingle(int id);

        IList<T> GetAll();

        IList<T> GetAll(Expression<Func<T, bool>> whereCondition);

        TransferObject<T> Save(T entry);

        TransferObject<bool> Delete(int id);
    }
}
