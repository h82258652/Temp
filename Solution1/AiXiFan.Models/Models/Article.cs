using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class Article
    {
        [JsonProperty("content")]
        public string Content
        {
            get;
            set;
        }
    }
}