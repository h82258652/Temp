using Newtonsoft.Json;

namespace AiXiFan.Models
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

        [JsonProperty("userName")]
        public string UserName
        {
            get;
            set;
        }
    }
}