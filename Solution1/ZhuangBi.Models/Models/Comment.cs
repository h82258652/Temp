using Newtonsoft.Json;

namespace ZhuangBi.Models
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

        [JsonProperty("uid")]
        public int Uid
        {
            get;
            set;
        }

        [JsonProperty("article_id")]
        public int ArticleId
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public string Message
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

        [JsonProperty("at_uid")]
        public int AtUid
        {
            get;
            set;
        }

        [JsonProperty("votes")]
        public int Votes
        {
            get;
            set;
        }

        [JsonProperty("user_info")]
        public ArticleCommentUserInfo UserInfo
        {
            get;
            set;
        }

        [JsonProperty("at_user_info")]
        public ArticleCommentUserInfo AtUserInfo
        {
            get;
            set;
        }

        [JsonProperty("vote_info")]
        public object VoteInfo
        {
            get;
            set;
        }
    }
}