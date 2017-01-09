using AcArticle.Models;
using AcArticle.Services;
using System;
using System.Threading.Tasks;

namespace AcArticle.Uwp.Design
{
    public class AcArticleService : IAcArticleService
    {
        public Task<ArticleCommentResult> GetArticleCommentsAsync(int contentId, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<ArticleResult> GetArticleDetailAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SearchResult> GetArticlesAsync(Channel channel, int pageNo, int pageSize, Sort sort)
        {
            throw new NotImplementedException();
        }
    }
}