using System.Threading.Tasks;
using ZhuangBi.Models;

namespace ZhuangBi.Services
{
    public interface IPeopleService
    {
        /// <summary>
        /// 我关注的人列表/关注者我的人列表
        /// </summary>
        /// <param name="uid">用户编号</param>
        /// <param name="type">关注的人：follows 关注者：fans</param>
        /// <param name="page">页码，默认1</param>
        /// <param name="perPage">每页记录数，默认为系统设置contents_per_page</param>
        /// <returns></returns>
        Task<ResultBase<GetFollowsResult>> GetFollowsAsync(int uid, GetFollowType type, int page = 1, int perPage = 10);

        Task<ResultBase> profile_setting(ProfileSetting profileSetting);

        Task<ResultBase<GetUserActionsArticleResult>> GetUserActionsArticleAsync(int uid, int per_page = 10, int page = 1);

        //Task<ResultBase<GetUserActionsQuestionResult>> GetUserActionsQuestionAsync(int uid, int per_page = 10, int page = 1);

        //Task<ResultBase<GetUserActionsAnswerResult>> GetUserActionsAnswerAsync(int uid, int per_page = 10, int page = 1);

        /// <summary>
        /// 关注的话题列表
        /// </summary>
        /// <param name="uid">用户编号</param>
        /// <param name="page">页码，默认1</param>
        /// <returns></returns>
        Task<ResultBase<TopicsResult>> GetTopicsAsync(int uid, int page = 1);
    }
}