using Newtonsoft.Json;

namespace AcArticle.Models
{
    [JsonObject]
    public class SearchDataItem
    {
        [JsonProperty("channelId")]
        public int ChannelId
        {
            get;
            set;
        }

        [JsonProperty("comments")]
        public int Comments
        {
            get;
            set;
        }

        [JsonProperty("contentId")]
        public string ContentId
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

        [JsonProperty("stows")]
        public int Stows
        {
            get;
            set;
        }

        [JsonProperty("tags")]
        public string[] Tags
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

        [JsonProperty("toplevel")]
        public int TopLevel
        {
            get;
            set;
        }

        [JsonProperty("user")]
        public User User
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

        [JsonProperty("views")]
        public int Views
        {
            get;
            set;
        }
    }
}