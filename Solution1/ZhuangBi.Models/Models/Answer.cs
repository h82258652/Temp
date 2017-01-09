using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class Answer
    {
        /// <summary>
        /// 回答编号
        /// </summary>
        [JsonProperty("answer_id")]
        public int AnswerId
        {
            get;
            set;
        }

        /// <summary>
        /// 问题编号
        /// </summary>
        [JsonProperty("question_id")]
        public int QuestionId
        {
            get;
            set;
        }

        /// <summary>
        /// 回答内容
        /// </summary>
        [JsonProperty("answer_content")]
        public string AnswerContent
        {
            get;
            set;
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        [JsonProperty("add_time")]
        public long AddTime
        {
            get;
            set;
        }

        /// <summary>
        /// 反对数目
        /// </summary>
        [JsonProperty("against_count")]
        public int AgainstCount
        {
            get;
            set;
        }

        /// <summary>
        /// 赞成数目
        /// </summary>
        [JsonProperty("agree_count")]
        public int AgreeCount
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

        /// <summary>
        /// 评论数目
        /// </summary>
        [JsonProperty("comment_count")]
        public int CommentCount
        {
            get;
            set;
        }

        [JsonProperty("uninterested_count")]
        public int UninterestedCount
        {
            get;
            set;
        }

        /// <summary>
        /// 感谢数目
        /// </summary>
        [JsonProperty("thanks_count")]
        public int ThanksCount
        {
            get;
            set;
        }

        [JsonProperty("category_id")]
        public int CategoryId
        {
            get;
            set;
        }

        [JsonProperty("has_attach")]
        public int HasAttach
        {
            get;
            set;
        }

        [JsonProperty("ip")]
        public long IP
        {
            get;
            set;
        }

        [JsonProperty("force_fold")]
        public int ForceFold
        {
            get;
            set;
        }

        [JsonProperty("anonymous")]
        public int Anonymous
        {
            get;
            set;
        }

        [JsonProperty("publish_source")]
        public string PublishSource
        {
            get;
            set;
        }

        /// <summary>
        /// 当前用户是否已支持或反对，已支持：1，已反对：-1，未表态：0
        /// </summary>
        [JsonProperty("user_vote_status")]
        public int UserVoteStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 当前用户是否已感谢，已感谢：1 未感谢：0
        /// </summary>
        [JsonProperty("user_thanks_status")]
        public int UserThanksStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 作者信息
        /// </summary>
        [JsonProperty("user_info")]
        public AnswerUser UserInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 问题标题
        /// </summary>
        [JsonProperty("question_content")]
        public string QuestionContent
        {
            get;
            set;
        }
    }
}