using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class UserAction
    {
        [JsonProperty("historyId")]
        public int HistoryId
        {
            get;
            set;
        }

        [JsonProperty("associate_action")]
        public int AssociateAction
        {
            get;
            set;
        }

        [JsonProperty("add_time")]
        public long AddTime
        {
            get;
            set;
        }

        [JsonProperty("article_info")]
        public ArticleInfo ArticleInfo
        {
            get;
            set;
        }
    }
}