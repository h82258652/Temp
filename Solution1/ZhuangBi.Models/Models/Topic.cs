using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class Topic
    {
        /// <summary>
        /// 话题编号
        /// </summary>
        [JsonProperty("topic_id")]
        public int TopicId
        {
            get;
            set;
        }

        /// <summary>
        /// 话题标题
        /// </summary>
        [JsonProperty("topic_title")]
        public string TopicTitle
        {
            get; set;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("add_time")]
        public long AddTime
        {
            get; set;
        }

        /// <summary>
        /// 讨论数
        /// </summary>
        [JsonProperty("discuss_count")]
        public int DiscussCount
        {
            get; set;
        }

        /// <summary>
        /// 话题描述
        /// </summary>
        [JsonProperty("topic_description")]
        public string TopicDescription
        {
            get; set;
        }

        /// <summary>
        /// 话题图片
        /// </summary>
        [JsonProperty("topic_pic")]
        public string TopicPic
        {
            get;
            set;
        }

        /// <summary>
        /// 是否已锁定，1:已锁定 0:未锁定
        /// </summary>
        [JsonProperty("topic_lock")]
        public int TopicLock
        {
            get;
            set;
        }

        /// <summary>
        /// 关注数
        /// </summary>
        [JsonProperty("focus_count")]
        public int FocusCount
        {
            get;
            set;
        }

        [JsonProperty("user_related")]
        public int UserRelated
        {
            get;
            set;
        }

        [JsonProperty("url_token")]
        public string UrlToken
        {
            get;
            set;
        }

        [JsonProperty("merged_id")]
        public int MergedId
        {
            get;
            set;
        }

        [JsonProperty("seo_title")]
        public string SeoTitle
        {
            get;
            set;
        }

        [JsonProperty("parent_id")]
        public int ParentId
        {
            get;
            set;
        }

        [JsonProperty("is_parent")]
        public int IsParent
        {
            get;
            set;
        }

        /// <summary>
        /// 最近一周讨论次数
        /// </summary>
        [JsonProperty("discuss_count_last_week")]
        public int DiscussCountLastWeek
        {
            get;
            set;
        }

        /// <summary>
        /// 最近一月讨论次数
        /// </summary>
        [JsonProperty("discuss_count_last_month")]
        public int DiscussCountLastMonth
        {
            get;
            set;
        }

        /// <summary>
        /// 最近一次讨论时间
        /// </summary>
        [JsonProperty("discuss_count_update")]
        public long DiscussCountUpdate
        {
            get;
            set;
        }

        /// <summary>
        /// 当前用户是否已关注该话题，1:已关注 0:未关注
        /// </summary>
        [JsonProperty("has_focus")]
        public int HasFocus
        {
            get;
            set;
        }
    }
}