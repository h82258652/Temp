using AcArticle.Models;
using AcArticle.Services;
using Microsoft.Toolkit.Uwp;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace AcArticle.Uwp.Adapters
{
    public class ArticleCommentAdapter : IIncrementalSource<ArticleComment>
    {
        private readonly IAcArticleService _acArticleService;

        private readonly int _contentId;

        public ArticleCommentAdapter(IAcArticleService acArticleService, int contentId)
        {
            _acArticleService = acArticleService;
            _contentId = contentId;
        }

        public async Task<IEnumerable<ArticleComment>> GetPagedItemsAsync(int pageIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await _acArticleService.GetArticleCommentsAsync(_contentId, pageIndex, pageSize);
            if (result.Code == HttpStatusCode.OK && result.Success)
            {
                return result.Data.Page.Map.Values;
            }
            return null;
        }
    }
}