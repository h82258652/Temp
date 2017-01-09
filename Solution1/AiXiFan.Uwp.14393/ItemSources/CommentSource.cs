using AiXiFan.Models;
using AiXiFan.Services;
using Microsoft.Toolkit.Uwp;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AiXiFan.Uwp.ItemSources
{
    public class CommentSource : IIncrementalSource<Comment>
    {
        private readonly IAiXiFanService _aiXiFanService;

        private readonly int _contentId;

        public CommentSource(IAiXiFanService aiXiFanService, int contentId)
        {
            _aiXiFanService = aiXiFanService;
            _contentId = contentId;
        }

        public async Task<IEnumerable<Comment>> GetPagedItemsAsync(int pageIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await _aiXiFanService.GetArticleCommentsAsync(_contentId, pageIndex + 1, pageSize);
            if (result.Success)
            {
                return result.Data.Page.Map.Values;
            }
            else
            {
                return Enumerable.Empty<Comment>();
            }
        }
    }
}