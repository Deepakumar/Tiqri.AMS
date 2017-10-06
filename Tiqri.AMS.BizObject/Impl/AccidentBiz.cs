using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.DataAccessObject.Repository;
using Tiqri.AMS.DataAccessObject.Repository.Impl;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.BizObject.Impl
{
    public class AccidentBiz : IAccidentBiz
    {
        IAccidentRepository _repository;
        //public AccidentCategoryBiz() : this(new AccidentCategoryRepository()) { }

        //public AccidentCategoryBiz(IAccidentCategoryRepository _repository) { this._repository = new AccidentCategoryRepository(); }

        /// <summary>
        /// 
        /// </summary>

        public AccidentBiz() { this._repository = new AccidentRepository(); }

        public bool CreateAccident(Accident accident)
        {
             _repository.InsertAccident(accident);
            return true;
        }

        public List<Accident> QueryAccident()
        {
            return _repository.QueryAccident();
        }
    }
}
