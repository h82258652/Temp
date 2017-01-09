using AiXiFan.Models;
using System.Threading.Tasks;

namespace AiXiFan.Services
{
    public interface IAiXiFanService
    {
        Task<ArticleResult> GetArticleAsync(int id);

        Task<ChannelResult> GetChannelsAsync();

        Task<RegionResult> GetRegionAsync(int belong, int? channelId);

        Task<GetUpdateCountsResult> GetUpdateCountsAsync(params int[] channelIds);

        Task<GetArticleCommentsResult> GetArticleCommentsAsync(int contentId, int pageNo, int pageSize);

        Task<VideoResult> GetVideoAsync(int id);

        Task<SearchResult> SearchAsync(int channelId, int pageNo, int pageSize, Sort sort);
    }
}