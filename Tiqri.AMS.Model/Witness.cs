using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiqri.AMS.Model
{
    public class Witness : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? EmployeeID { get; set; }
        public int AccidentID { get; set; }
        public virtual Accident Accident { get; set; }
    }
}
