using Newtonsoft.Json;

namespace AcArticle.Models
{
    [JsonObject]
    public class User
    {
        [JsonProperty("userImg")]
        public string UserImg
        {
            get;
            set;
        }

        [JsonProperty("userId")]
        public int UserId
        {
            get;
            set;
        }

        [JsonProperty("username")]
        public string Username
        {
            get;
            set;
        }
    }
}