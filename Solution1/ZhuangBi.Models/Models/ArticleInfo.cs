using Newtonsoft.Json;
using System.Collections.Generic;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class ArticleInfo
    {
        /// <summary>
        /// 文章编号
        /// </summary>
        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// 作者uid
        /// </summary>
        [JsonProperty("uid")]
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// 文章内容
        /// </summary>
        [JsonProperty("message")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>
        /// 评论数目
        /// </summary>
        [JsonProperty("comments")]
        public int Comments
        {
            get;
            set;
        }

        /// <summary>
        /// 浏览量
        /// </summary>
        [JsonProperty("views")]
        public int Views
        {
            get;
            set;
        }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonProperty("add_time")]
        public long AddTime
        {
            get;
            set;
        }

        /// <summary>
        /// 有附件：1，无附件：0
        /// </summary>
        [JsonProperty("has_attach")]
        public int HasAttach
        {
            get;
            set;
        }

        [JsonProperty("lock")]
        public int Lock
        {
            get;
            set;
        }

        /// <summary>
        /// 点赞数
        /// </summary>
        [JsonProperty("votes")]
        public int Votes
        {
            get;
            set;
        }

        [JsonProperty("title_fulltext")]
        public string TitleFullText
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

        [JsonProperty("is_recommend")]
        public int IsRecommend
        {
            get;
            set;
        }

        [JsonProperty("chapter_id")]
        public object ChapterId
        {
            get;
            set;
        }

        [JsonProperty("sort")]
        public int Sort
        {
            get;
            set;
        }

        /// <summary>
        /// 作者信息
        /// </summary>
        [JsonProperty("user_info")]
        public ArticleUserInfo UserInfo
        {
            get;
            set;
        }

        [JsonProperty("vote_info")]
        public ArticleVoteInfo VoteInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 点赞用户信息列表（前10条）
        /// </summary>
        [JsonProperty("vote_users")]
        public Dictionary<string, ArticleVoteUser> VoteUsers
        {
            get;
            set;
        }

        /// <summary>
        /// 当前用户是否已关注该作者, 1:已关注 0:未关注
        /// </summary>
        [JsonProperty("user_follow_check")]
        public int UserFollowCheck
        {
            get;
            set;
        }
    }
}