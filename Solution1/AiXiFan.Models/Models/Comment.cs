using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class Comment
    {
        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty("quoteId")]
        public int QuoteId
        {
            get;
            set;
        }

        [JsonProperty("refCount")]
        public int RefCount
        {
            get;
            set;
        }

        [JsonProperty("content")]
        public string Content
        {
            get;
            set;
        }

        [JsonProperty("time")]
        public long Time
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

        [JsonProperty("avatar")]
        public string Avatar
        {
            get;
            set;
        }

        [JsonProperty("floor")]
        public int Floor
        {
            get;
            set;
        }

        [JsonProperty("deep")]
        public int Deep
        {
            get;
            set;
        }

        [JsonProperty("isAt")]
        public int IsAt
        {
            get;
            set;
        }

        [JsonProperty("nameRed")]
        public int NameRed
        {
            get;
            set;
        }

        [JsonProperty("avatarFrame")]
        public int AvatarFrame
        {
            get;
            set;
        }

        [JsonProperty("isDelete")]
        public bool IsDelete
        {
            get;
            set;
        }

        [JsonProperty("isUpDelete")]
        public bool IsUpDelete
        {
            get;
            set;
        }
    }
}