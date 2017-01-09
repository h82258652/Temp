using Newtonsoft.Json;
using System.Collections.Generic;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class JobsList
    {
        [JsonProperty("jobs_list")]
        public Dictionary<string, string> Value
        {
            get;
            set;
        }
    }
}