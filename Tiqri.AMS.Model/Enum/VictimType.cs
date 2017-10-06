using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiqri.AMS.Model.Enum
{
    public enum  VictimType
    {
        [Display(Name = "Employee")]
        Employee =1,
        [Display(Name = "Short Term Contractor")]
        ShortTermContractor =2,
        [Display(Name = "Member Of Public")]
        MemberOfPublic =3

    }
}
