using AiXiFan.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AiXiFan.Services
{
    public class AiXiFanService : IAiXiFanService
    {
        public async Task<ArticleResult> GetArticleAsync(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            using (var client = CreateHttpClient())
            {
                var json = await client.GetStringAsync($"{Constants.AiXiFanUrlBase}/articles/{id}");
                return JsonConvert.DeserializeObject<ArticleResult>(json);
            }
        }

        public async Task<ChannelResult> GetChannelsAsync()
        {
            using (var client = CreateHttpClient())
            {
                var json = await client.GetStringAsync($"{Constants.AiXiFanUrlBase}/channels/allChannels");
                return JsonConvert.DeserializeObject<ChannelResult>(json);
            }
        }

        public async Task<RegionResult> GetRegionAsync(int belong, int? channelId)
        {
            using (var client = CreateHttpClient())
            {
                var urlBuilder = new StringBuilder();
                urlBuilder.Append($"{Constants.AiXiFanUrlBase}/regions?belong={belong}&loadCount=-1");
                if (channelId.HasValue)
                {
                    urlBuilder.Append($"&channelId={channelId}");
                }
                var json = await client.GetStringAsync(urlBuilder.ToString());
                return JsonConvert.DeserializeObject<RegionResult>(json);
            }
        }

        public async Task<GetUpdateCountsResult> GetUpdateCountsAsync(params int[] channelIds)
        {
            if (channelIds == null)
            {
                throw new ArgumentNullException(nameof(channelIds));
            }

            var parameter = string.Join(",", channelIds);
            using (var client = CreateHttpClient())
            {
                // TODO
                var json = await client.GetStringAsync($"http://api.acfun.tv/apiserver/home/getUpdateCounts?channelIds={parameter}");
                return JsonConvert.DeserializeObject<GetUpdateCountsResult>(json);
            }
        }

        public async Task<GetArticleCommentsResult> GetArticleCommentsAsync(int contentId, int pageNo, int pageSize)
        {
            using (var client = CreateHttpClient())
            {
                // TODO
                var json = await client.GetStringAsync($"http://mobile.acfun.tv/comment/content/list?version=4&contentId={contentId}&pageSize={pageSize}&pageNo={pageNo}");
                return JsonConvert.DeserializeObject<GetArticleCommentsResult>(json);
            }
        }

        public async Task<VideoResult> GetVideoAsync(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            using (var client = CreateHttpClient())
            {
                var json = await client.GetStringAsync($"{Constants.AiXiFanUrlBase}/videos/{id}");
                return JsonConvert.DeserializeObject<VideoResult>(json);
            }
        }

        public async Task<SearchResult> SearchAsync(int channelId, int pageNo, int pageSize, Sort sort)
        {
            using (var client = CreateHttpClient())
            {
                var json = await client.GetStringAsync($"{Constants.AiXiFanUrlBase}/searches/channel?channelIds={channelId}&pageNo={pageNo}&pageSize={pageSize}&sort={(int)sort}");
                return JsonConvert.DeserializeObject<SearchResult>(json);
            }
        }

        private HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            // TODO to real information.
            client.DefaultRequestHeaders.Add("appVersion", "4.3.0");
            client.DefaultRequestHeaders.Add("deviceType", "1");
            client.DefaultRequestHeaders.Add("market", "portal");
            client.DefaultRequestHeaders.Add("productId", "2000");
            client.DefaultRequestHeaders.Add("resolution", "720x1280");
            // TODO use ASHWID, see http://www.cnblogs.com/lihaiyin/archive/2012/09/25/2701709.html
            client.DefaultRequestHeaders.Add("udid", "ce7f03e8-684e-3d0e-b80f-0d5002c3b393");
            return client;
        }
    }
}