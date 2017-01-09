namespace AcArticle.Models
{
    public enum Sort
    {
        /// <summary>
        /// 围观最多
        /// </summary>
        ViewsDescending = 1,

        /// <summary>
        /// 评论最多
        /// </summary>
        CommentsDescending = 2,

        /// <summary>
        /// 最新发布
        /// </summary>
        PublishNewest = 4,

        /// <summary>
        /// 最新回复
        /// </summary>
        ReplyNewest = 5
    }
}