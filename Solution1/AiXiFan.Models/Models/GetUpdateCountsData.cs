using Newtonsoft.Json;
using System.Collections.Generic;

namespace AiXiFan.Models
{
    [JsonObject]
    public class GetUpdateCountsData
    {
        [JsonProperty("list")]
        public Dictionary<int, int> List
        {
            get;
            set;
        }
    }
}