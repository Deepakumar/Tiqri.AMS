using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tiqri.AMS.Web.ViewModel
{
    public static class Serialize
    {
        public static string ToJson(this Accident self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this Victim self) => JsonConvert.SerializeObject(self, Converter.Settings);

    }
}