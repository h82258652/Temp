using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class VoteInfo
    {
        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty("uid")]
        public int UserId
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }

        [JsonProperty("item_id")]
        public int ItemId
        {
            get;
            set;
        }

        /// <summary>
        /// 当前用户的投票状态 1赞同 -1 反对；如果vote_info为空，表示未表态
        /// </summary>
        [JsonProperty("rating")]
        public int Rating
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

        [JsonProperty("reputation_factor")]
        public int ReputationFactor
        {
            get;
            set;
        }

        [JsonProperty("item_uid")]
        public int ItemUid
        {
            get;
            set;
        }
    }
}