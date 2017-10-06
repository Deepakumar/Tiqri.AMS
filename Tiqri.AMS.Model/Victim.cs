using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.Model.Enum;

namespace Tiqri.AMS.Model
{
    public class Victim : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public VictimType VictimType { get; set; }
        public string EmployeeID { get; set; }
        public int AccidentID { get; set; }
        public virtual Accident Accident { get; set; }
    }
}
