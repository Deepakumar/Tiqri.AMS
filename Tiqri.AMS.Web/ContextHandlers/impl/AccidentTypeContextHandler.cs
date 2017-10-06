using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tiqri.AMS.BizObject;
using ViewModel =  Tiqri.AMS.Web.ViewModel;

namespace Tiqri.AMS.Web.ContextHandlers
{
    public class AccidentTypeContextHandler : IAccidentTypeContextHandler
    {
        IAccidentCategoryBiz accidentCategoryBiz;

        public AccidentTypeContextHandler()
        {
            accidentCategoryBiz = new AccidentCategoryBiz();
        }
        public AccidentTypeContextHandler(IAccidentCategoryBiz accidentCategoryBiz)
        {
            this.accidentCategoryBiz = accidentCategoryBiz;
        }

        public List<ViewModel.AccidentCategory> GetAccidentCategoryList()
        {
            List<ViewModel.AccidentCategory> cateList= null;

            var accCateList = accidentCategoryBiz.GetAccidentCategoryList();
            if(accCateList != null)
            {
                cateList = new List<ViewModel.AccidentCategory>();

                foreach (var item in accCateList)
                {
                    cateList.Add(new ViewModel.AccidentCategory() { ID = item.ID.Value, Name = item.Name });
                }
            }

            return cateList;
        }
    }
}