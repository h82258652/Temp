using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class ArticleData : DataBase
    {
        [JsonProperty("article")]
        public Article Article
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

        [JsonProperty("display")]
        public int Display
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

        [JsonProperty("owner")]
        public Owner Owner
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

        [JsonProperty("updatedAt")]
        public long UpdatedAt
        {
            get;
            set;
        }
    }
}