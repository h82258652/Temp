using AcArticle.Models;
using AcArticle.Services;
using Microsoft.Toolkit.Uwp;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace AcArticle.Uwp.Adapters
{
    public class ArticleAdapter : IIncrementalSource<SearchDataItem>
    {
        private readonly IAcArticleService _acArticleService;

        public ArticleAdapter(IAcArticleService acArticleService, Channel channel)
        {
            _acArticleService = acArticleService;
            Channel = channel;
        }

        public Channel Channel
        {
            get;
        }

        public async Task<IEnumerable<SearchDataItem>> GetPagedItemsAsync(int pageIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await _acArticleService.GetArticlesAsync(Channel, pageIndex, pageSize, Sort.PublishNewest);
            if (result.Code == HttpStatusCode.OK)
            {
                return result.Data.List;
            }
            return null;
        }
    }
}