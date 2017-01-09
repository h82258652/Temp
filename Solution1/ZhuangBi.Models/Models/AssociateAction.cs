namespace ZhuangBi.Models
{
    public enum AssociateAction
    {
        /// <summary>
        /// 添加问题
        /// </summary>
        AddQuestion = 101,

        /// <summary>
        /// 修改问题标题
        /// </summary>
        ModifyQuestionTitle = 102,

        /// <summary>
        /// 修改问题描述
        /// </summary>
        ModifyQuestionDescription = 103,

        /// <summary>
        /// 添加问题关注
        /// </summary>
        AddRequestionFocus = 105,

        /// <summary>
        /// 问题重定向
        /// </summary>
        RedirectQuestion = 107,

        /// <summary>
        /// 修改问题分类
        /// </summary>
        ModifyQuestionCategory = 108,

        /// <summary>
        /// 修改问题附件
        /// </summary>
        ModifyQuestionAttach = 109,

        /// <summary>
        /// 删除问题重定向
        /// </summary>
        DeleteRedirectQuestion = 110,

        /// <summary>
        /// 回复问题
        /// </summary>
        AnswerQuestion = 201,

        /// <summary>
        /// 赞同答案
        /// </summary>
        AddAgree = 204,

        /// <summary>
        /// 加感谢作者
        /// </summary>
        AddUseful = 206,

        /// <summary>
        /// 问题没有帮助
        /// </summary>
        AddUnuseful = 207,

        /// <summary>
        /// 创建话题
        /// </summary>
        AddTopic = 401,

        /// <summary>
        /// 修改话题
        /// </summary>
        ModifyTopic = 402,

        /// <summary>
        /// 修改话题描述
        /// </summary>
        ModifyTopicDescription = 403,

        /// <summary>
        /// 修改话题图片
        /// </summary>
        ModifyTopicPicture = 404,

        /// <summary>
        /// 删除话题
        /// </summary>
        DeleteTopic = 405,

        /// <summary>
        /// 添加话题关注
        /// </summary>
        AddTopicFocus = 406,

        /// <summary>
        /// 添加相关话题
        /// </summary>
        AddRelatedTopic = 410,

        /// <summary>
        /// 删除相关话题
        /// </summary>
        DeleteRelatedTopic = 411,

        /// <summary>
        /// 添加文章
        /// </summary>
        AddArticle = 501,

        /// <summary>
        /// 赞同文章
        /// </summary>
        AddAgreeArticle = 502,

        /// <summary>
        /// 评论文章
        /// </summary>
        AddCommentArticle = 503,
    }
}