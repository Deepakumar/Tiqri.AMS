using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tiqri.AMS.Model.Enum
{
    public enum TypeOfLocation
    {
        [Display(Name = "At These Premises")]
        [EnumMember(Value = "At These Premises")]
        AtThesePremises =1,
        [Display(Name = "Elsewhere In the Organization")]
        [EnumMember(Value = "Elsewhere In the Organization")]
        ElsewhereInTheOrganization =2,
        [Display(Name = "At Someone else's premises")]
        [EnumMember(Value = "At Someone else's premises")]
        AtSomeoneElsePremises = 3,
        [Display(Name = "In a plublic place")]
        [EnumMember(Value = "In a plublic place")]
        InAPlublicPlace = 4,
        [Display(Name = "In Highway")]
        [EnumMember(Value = "In Highway")]
        InHighway =5
    }
}
