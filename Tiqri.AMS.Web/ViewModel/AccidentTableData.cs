using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tiqri.AMS.Model.Enum;

namespace Tiqri.AMS.Web.ViewModel
{
    public class AccidentTableData
    {
        public int AccidentID { get; set; }
        public string AccidentRefNo { get; set; }
        public string Reporter { get; set; }
        public string Date { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TypeOfLocation Location { get; set; }

    }
}