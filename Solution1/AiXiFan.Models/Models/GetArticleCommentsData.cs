using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class GetArticleCommentsData
    {
        [JsonProperty("cache")]
        public string Cache
        {
            get;
            set;
        }

        [JsonProperty("page")]
        public Page Page
        {
            get;
            set;
        }
    }
}