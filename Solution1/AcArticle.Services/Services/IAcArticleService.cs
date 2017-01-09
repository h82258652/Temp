using AcArticle.Models;
using System.Threading.Tasks;

namespace AcArticle.Services
{
    public interface IAcArticleService
    {
        Task<ArticleCommentResult> GetArticleCommentsAsync(int contentId, int pageNo, int pageSize);

        Task<ArticleResult> GetArticleDetailAsync(int id);

        Task<SearchResult> GetArticlesAsync(Channel channel, int pageNo, int pageSize, Sort sort);
    }
}