using System.Threading.Tasks;
using ZhuangBi.Models;

namespace ZhuangBi.Services
{
    public interface IQuestionService
    {
        /// <summary>
        /// 单条答案详情
        /// </summary>
        /// <param name="answerId">答案编号</param>
        /// <returns></returns>
        Task<ResultBase<GetAnswerResult>> GetAnswerAsync(int answerId);

        Task GetAsync(int id, int page = 1, string sort_key = "agree_count", string sort = "DESC");
    }
}