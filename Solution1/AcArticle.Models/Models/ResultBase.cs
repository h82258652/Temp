using Newtonsoft.Json;
using System.Net;

namespace AcArticle.Models
{
    [JsonObject]
    public class ResultBase
    {
        [JsonProperty("code")]
        public virtual HttpStatusCode Code
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public virtual string Message
        {
            get;
            set;
        }
    }
}