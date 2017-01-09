using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class FollowRow
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

        [JsonProperty("agree_count")]
        public int AgreeCount
        {
            get;
            set;
        }

        [JsonProperty("thanks_count")]
        public int ThanksCount
        {
            get;
            set;
        }

        [JsonProperty("reputation")]
        public int Reputation
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