using Newtonsoft.Json;

namespace AcArticle.Models
{
    [JsonObject]
    public class Owner
    {
        [JsonProperty("avatar")]
        public string Avatar
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

        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    }
}