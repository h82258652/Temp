using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class GetArticleResult
    {
        [JsonProperty("article_info")]
        public Article ArticleInfo
        {
            get;
            set;
        }
    }
}