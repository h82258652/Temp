using Newtonsoft.Json;
using System.Net;

namespace AcArticle.Models
{
    [JsonObject]
    public class ArticleCommentResult : ResultBase<ArticleCommentData>
    {
        [JsonProperty("success")]
        public bool Success
        {
            get;
            set;
        }

        [JsonProperty("msg")]
        public override string Message
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public override HttpStatusCode Code
        {
            get;
            set;
        }
    }
}