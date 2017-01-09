using AcArticle.Models.Converters;
using Newtonsoft.Json;

namespace AcArticle.Models
{
    [JsonObject]
    public class ArticleComment
    {
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }

        [JsonProperty("quoteId")]
        public string QuoteId
        {
            get;
            set;
        }

        [JsonConverter(typeof(IntegerConverter))]
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

        [JsonConverter(typeof(IntegerConverter))]
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

        [JsonConverter(typeof(IntegerConverter))]
        [JsonProperty("floor")]
        public int Floor
        {
            get;
            set;
        }

        [JsonConverter(typeof(IntegerConverter))]
        [JsonProperty("deep")]
        public int Deep
        {
            get;
            set;
        }

        [JsonConverter(typeof(IntegerConverter))]
        [JsonProperty("isAt")]
        public int IsAt
        {
            get;
            set;
        }

        [JsonConverter(typeof(IntegerConverter))]
        [JsonProperty("nameRed")]
        public int NameRed
        {
            get;
            set;
        }

        [JsonConverter(typeof(IntegerConverter))]
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