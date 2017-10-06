using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tiqri.AMS.Web.ViewModel
{
    public class Victim
    {
        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("$$hashKey")]
        public string HashKey { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("typeId")]
        public string TypeId { get; set; }

        [JsonProperty("victimTypeName")]
        public string VictimTypeName { get; set; }
    }
}