using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.Model.Enum;

namespace Tiqri.AMS.Model
{
    public class Accident : EntityBase
    {
        public string ReferenceNo { get; set; }
        public int ActionCategoryID { get; set; }
        public string ReporterID { get; set; }
        public AccidentStatus Status { get; set; }
        public int? InvestigationID { get; set; }
        public TypeOfLocation TypeOfLocation { get; set; }
        public String History { get; set; }
        public DateTime AccidentDate { get; set; }
        public virtual AccidentCategory AccidentCategory { get; set; }
        public virtual Investigation Investigation { get; set; }
        public virtual IList<Witness> WitnessList { get; set; }
        public virtual IList<Victim> VictimList { get; set; }
    }
}
