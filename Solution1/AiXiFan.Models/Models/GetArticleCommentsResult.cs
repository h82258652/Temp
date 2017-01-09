using Newtonsoft.Json;
using System.Net;

namespace AiXiFan.Models
{
    [JsonObject]
    public class GetArticleCommentsResult : ResultBase<GetArticleCommentsData>
    {
        [JsonProperty("success")]
        public bool Success
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public new HttpStatusCode Code
        {
            get;
            set;
        }
    }
}