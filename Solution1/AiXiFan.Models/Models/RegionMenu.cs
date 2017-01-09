using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class RegionMenu
    {
        [JsonProperty("actionId")]
        public int ActionId
        {
            get;
            set;
        }

        [JsonProperty("channelId")]
        public int ChannelId
        {
            get;
            set;
        }

        [JsonProperty("hide")]
        public int Hide
        {
            get;
            set;
        }

        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty("image")]
        public string Image
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

        [JsonProperty("regionId")]
        public int RegionId
        {
            get;
            set;
        }

        [JsonProperty("sort")]
        public int Sort
        {
            get;
            set;
        }

        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    }
}