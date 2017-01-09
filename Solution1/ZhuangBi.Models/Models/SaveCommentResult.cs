using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class SaveCommentResult
    {
        /// <summary>
        /// 评论编号
        /// </summary>
        [JsonProperty("comment_id")]
        public int CommentId
        {
            get;
            set;
        }
    }
}