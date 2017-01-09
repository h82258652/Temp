using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class UserInfo
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        [JsonProperty("uid")]
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// 头像
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar
        {
            get;
            set;
        }

        /// <summary>
        /// 性别，1:男，2:女，3:保密
        /// </summary>
        [JsonProperty("sex")]
        public Gender Gender
        {
            get;
            set;
        }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonProperty("province")]
        public string Province
        {
            get;
            set;
        }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("city")]
        public string City
        {
            get;
            set;
        }

        /// <summary>
        /// 粉丝数
        /// </summary>
        [JsonProperty("fans_count")]
        public int FansCount
        {
            get;
            set;
        }

        /// <summary>
        /// 关注数
        /// </summary>
        [JsonProperty("friend_count")]
        public int FriendCount
        {
            get;
            set;
        }

        /// <summary>
        /// 文章数
        /// </summary>
        [JsonProperty("article_count")]
        public int ArticleCount
        {
            get;
            set;
        }

        /// <summary>
        /// 问题数
        /// </summary>
        [JsonProperty("question_count")]
        public int QuestionCount
        {
            get;
            set;
        }

        /// <summary>
        /// 回答数
        /// </summary>
        [JsonProperty("answer_count")]
        public int AnswerCount
        {
            get;
            set;
        }

        /// <summary>
        /// 关注话题数
        /// </summary>
        [JsonProperty("topic_focus_count")]
        public int TopicFocusCount
        {
            get;
            set;
        }

        /// <summary>
        /// 获得赞同数
        /// </summary>
        [JsonProperty("agree_count")]
        public int AgreeCount
        {
            get;
            set;
        }

        /// <summary>
        /// 获得感谢数
        /// </summary>
        [JsonProperty("thanks_count")]
        public int ThanksCount
        {
            get;
            set;
        }

        /// <summary>
        /// 个人主页查看数
        /// </summary>
        [JsonProperty("views_count")]
        public int ViewsCount
        {
            get;
            set;
        }

        /// <summary>
        /// 一句话签名
        /// </summary>
        [JsonProperty("signature")]
        public string Signature
        {
            get;
            set;
        }

        /// <summary>
        /// 答案被收藏次数
        /// </summary>
        [JsonProperty("answer_favorite_count")]
        public int AnswerFavoriteCount
        {
            get;
            set;
        }

        /// <summary>
        /// 当前用户是否关注了该用户, 1:已关注，0:未关注
        /// </summary>
        [JsonProperty("has_focus")]
        public int HasFocus
        {
            get;
            set;
        }
    }
}