using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class AnswerUser
    {
        [JsonProperty("uid")]
        public int Uid
        {
            get;
            set;
        }

        [JsonProperty("user_name")]
        public string UserName
        {
            get;
            set;
        }

        [JsonProperty("signature")]
        public string Signature
        {
            get;
            set;
        }

        [JsonProperty("avatar_file")]
        public string AvatarFile
        {
            get;
            set;
        }
    }
}