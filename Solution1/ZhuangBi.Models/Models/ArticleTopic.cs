using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class ArticleTopic
    {
        [JsonProperty("topic_id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty("topic_title")]
        public string Title
        {
            get;
            set;
        }
    }
}