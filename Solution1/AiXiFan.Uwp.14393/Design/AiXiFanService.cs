using AiXiFan.Models;
using AiXiFan.Services;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace AiXiFan.Uwp.Design
{
    public class AiXiFanService : IAiXiFanService
    {
        public async Task<ArticleResult> GetArticleAsync(int id)
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Design/GetArticleAsync_3133442.json"));
            var json = await FileIO.ReadTextAsync(file);
            return JsonConvert.DeserializeObject<ArticleResult>(json);
        }

        public async Task<GetArticleCommentsResult> GetArticleCommentsAsync(int contentId, int pageNo, int pageSize)
        {
            StorageFile file = null;
            if (pageNo == 1)
            {
                file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Design/GetArticleCommentsAsync_3133442_1_20.json"));
            }
            else
            {
                file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Design/GetArticleCommentsAsync_3133442_2_20.json"));
            }
            var json = await FileIO.ReadTextAsync(file);
            return JsonConvert.DeserializeObject<GetArticleCommentsResult>(json);
        }

        public async Task<ChannelResult> GetChannelsAsync()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Design/GetChannelsAsync.json"));
            var json = await FileIO.ReadTextAsync(file);
            return JsonConvert.DeserializeObject<ChannelResult>(json);
        }

        public async Task<RegionResult> GetRegionAsync(int belong, int? channelId)
        {
            StorageFile file = null;
            if (belong == 11 && channelId == 63)
            {
                file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Design/GetRegionAsync_11_63.json"));
            }
            var json = await FileIO.ReadTextAsync(file);
            return JsonConvert.DeserializeObject<RegionResult>(json);
        }

        public async Task<GetUpdateCountsResult> GetUpdateCountsAsync(params int[] channelIds)
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Design/GetUpdateCountsAsync.json"));
            var json = await FileIO.ReadTextAsync(file);
            return JsonConvert.DeserializeObject<GetUpdateCountsResult>(json);
        }

        public Task<VideoResult> GetVideoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SearchResult> SearchAsync(int channelId, int pageNo, int pageSize, Sort sort)
        {
            throw new NotImplementedException();
        }
    }
}