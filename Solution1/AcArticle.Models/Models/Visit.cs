using Newtonsoft.Json;

namespace AcArticle.Models
{
    [JsonObject]
    public class Visit
    {
        [JsonProperty("comments")]
        public int Comments
        {
            get;
            set;
        }

        [JsonProperty("danmakuSize")]
        public int DanmakuSize
        {
            get;
            set;
        }

        [JsonProperty("goldBanana")]
        public int GoldBanana
        {
            get;
            set;
        }

        [JsonProperty("score")]
        public int Score
        {
            get;
            set;
        }

        [JsonProperty("stows")]
        public int Stows
        {
            get;
            set;
        }

        [JsonProperty("ups")]
        public int Ups
        {
            get;
            set;
        }

        [JsonProperty("views")]
        public int Views
        {
            get;
            set;
        }
    }
}