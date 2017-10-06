using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.DataAccessObject;
using Tiqri.AMS.DataAccessObject.Repository;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.BizObject
{
    public class AccidentCategoryBiz : BizObjectBase<AccidentCategory> , IAccidentCategoryBiz
    {
        IAccidentCategoryRepository _repository;
        //public AccidentCategoryBiz() : this(new AccidentCategoryRepository()) { }

        //public AccidentCategoryBiz(IAccidentCategoryRepository _repository) { this._repository = new AccidentCategoryRepository(); }

            /// <summary>
            /// 
            /// </summary>

        public AccidentCategoryBiz() { this._repository = new AccidentCategoryRepository(); }

        public List<AccidentCategory> GetAccidentCategoryList()
        {
            return _repository.GetAccidentCategoryList();
        }
    }

}
