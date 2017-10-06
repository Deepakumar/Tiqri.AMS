using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiqri.AMS.Model
{
    public class InvestigationAction : EntityBase
    {
        public string Action { get; set; }

        public int InvestigationID { get; set; }

        public virtual Investigation Investigation { get; set; }
    }
}
