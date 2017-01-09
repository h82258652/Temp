using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class Article
    {
        [JsonProperty("article_info")]
        public ArticleInfo Info
        {
            get;
            set;
        }

        /// <summary>
        /// 文章所属话题信息
        /// </summary>
        [JsonProperty("article_topics")]
        public ArticleTopic[] Topics
        {
            get;
            set;
        }

        /// <summary>
        /// 评论列表
        /// </summary>
        [JsonProperty("comments")]
        public Comment[] Comments
        {
            get;
            set;
        }
    }
}