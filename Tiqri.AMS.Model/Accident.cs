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
        public int? WitnessID { get; set; }
        public int ReporterID { get; set; }
        public AccidentStatus Status { get; set; }
        public int? InvestigationID { get; set; }

        public virtual AccidentCategory AccidentCategory { get; set; }
        public virtual Investigation Investigation { get; set; }
        public virtual IList<Witness> WitnessList { get; set; }
        public virtual IList<Victim> VictimList { get; set; }
    }
}
