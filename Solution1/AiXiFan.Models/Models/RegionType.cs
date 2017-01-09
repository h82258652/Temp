using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class RegionType
    {
        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    }
}