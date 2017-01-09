using Newtonsoft.Json;

namespace AcArticle.Models
{
    [JsonObject]
    public class ArticleData
    {
        [JsonProperty("article")]
        public Article Article
        {
            get;
            set;
        }

        [JsonProperty("channelId")]
        public int ChannelId
        {
            get;
            set;
        }

        [JsonProperty("contentId")]
        public int ContentId
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

        [JsonProperty("display")]
        public int Display
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

        [JsonProperty("isComment")]
        public bool IsComment
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

        [JsonProperty("owner")]
        public Owner Owner
        {
            get;
            set;
        }

        [JsonProperty("parentChannelId")]
        public int ParentChannelId
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

        [JsonProperty("status")]
        public int Status
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

        [JsonProperty("topLevel")]
        public int TopLevel
        {
            get;
            set;
        }

        [JsonProperty("updatedAt")]
        public long UpdatedAt
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