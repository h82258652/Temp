using Newtonsoft.Json;

namespace AcArticle.Models
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