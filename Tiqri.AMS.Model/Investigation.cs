using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiqri.AMS.Model
{
    public class Investigation : EntityBase
    {
        public int InvestigationOfficerID { get; set; }

        public Accident Accident { get; set; }

        public virtual IList<InvestigationAction> InvestigationActionList { get; set; }
    }
}
