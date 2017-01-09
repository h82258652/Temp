using Newtonsoft.Json;

namespace AcArticle.Models
{
    [JsonObject]
    public class ArticleCommentData
    {
        [JsonProperty("cache")]
        public string Cache
        {
            get;
            set;
        }

        [JsonProperty("page")]
        public ArticleCommentPage Page
        {
            get;
            set;
        }
    }
}