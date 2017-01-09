using Newtonsoft.Json;
using System.Net;

namespace AiXiFan.Models
{
    [JsonObject]
    public class ResultBase
    {
        [JsonProperty("code")]
        public HttpStatusCode Code
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }
    }
}