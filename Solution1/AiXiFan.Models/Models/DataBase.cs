using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class DataBase
    {
        [JsonProperty("channelId")]
        public int ChannelId
        {
            get;
            set;
        }

        [JsonProperty("cover")]
        public string Cover
        {
            get;
            set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get;
            set;
        }

        [JsonProperty("isArticle")]
        public int IsArticle
        {
            get;
            set;
        }

        [JsonProperty("isRecommend")]
        public int IsRecommend
        {
            get;
            set;
        }

        [JsonProperty("releaseDate")]
        public long ReleaseDate
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }

        [JsonProperty("topLevel")]
        public int TopLevel
        {
            get;
            set;
        }

        [JsonProperty("viewOnly")]
        public int ViewOnly
        {
            get;
            set;
        }

        [JsonProperty("visit")]
        public Visit Visit
        {
            get;
            set;
        }
    }
}