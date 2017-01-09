using System.Threading.Tasks;
using ZhuangBi.Models;

namespace ZhuangBi.Services
{
    public interface IArticleService
    {
        /// <summary>
        /// 获取文章详细信息
        /// </summary>
        /// <param name="id">文章编号</param>
        /// <param name="page">评论页码，页码从1开始，默认1，每页100条数据</param>
        /// <returns></returns>
        Task<ResultBase<GetArticleResult>> GetAsync(int id, int page = 1);

        Task<ResultBase<SaveCommentResult>> SaveCommentAsync(int articleId, string message, int? atUid);
    }
}