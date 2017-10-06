using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tiqri.AMS.Web.ViewModel
{
    public partial class Accident
    {
        [JsonProperty("reporterId")]
        public string ReportedId { get; set; }

        [JsonProperty("history")]
        public string History { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("locationTypeId")]
        public int LocationTypeId { get; set; }

        [JsonProperty("titleId")]
        public int TitleId { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("victims")]
        public Victim[] Victims { get; set; }
    }

    public partial class Accident
    {
        public static Accident FromJson(string json) => JsonConvert.DeserializeObject<Accident>(json, Converter.Settings);
    }

    

    
}