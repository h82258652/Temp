using AcArticle.Models;
using Newtonsoft.Json;
using SoftwareKobo.Support;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AcArticle.Services
{
    public class AcArticleService : IAcArticleService
    {
        private static readonly string Udid = Guid.NewGuid().ToString();

        private readonly IScreenService _screenService;

        public AcArticleService(IScreenService screenService)
        {
            _screenService = screenService;
        }

        public async Task<ArticleCommentResult> GetArticleCommentsAsync(int contentId, int pageNo, int pageSize)
        {
            using (var client = CreateHttpClient())
            {
                var json = await client.GetStringAsync(string.Format(Constants.AcFunCommentUrl, contentId, pageSize, pageNo));
                return JsonConvert.DeserializeObject<ArticleCommentResult>(json);
            }
        }

        public async Task<ArticleResult> GetArticleDetailAsync(int id)
        {
            using (var client = CreateHttpClient())
            {
                var json = await client.GetStringAsync($"{Constants.AiXiFanUrlBase}/articles/{id}");
                return JsonConvert.DeserializeObject<ArticleResult>(json);
            }
        }

        public async Task<SearchResult> GetArticlesAsync(Channel channel, int pageNo, int pageSize, Sort sort)
        {
            using (var client = CreateHttpClient())
            {
                var json = await client.GetStringAsync($"{Constants.AiXiFanUrlBase}/searches/channel?channelIds={(int)channel}&pageNo={pageNo}&pageSize={pageSize}&sort={(int)sort}");
                return JsonConvert.DeserializeObject<SearchResult>(json);
            }
        }

        protected virtual HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("appVersion", Constants.AppVersion);
            client.DefaultRequestHeaders.Add("deviceType", "1");
            client.DefaultRequestHeaders.Add("market", "portal");
            client.DefaultRequestHeaders.Add("productId", "2000");
            client.DefaultRequestHeaders.Add("resolution", $"{_screenService.ScreenWidthInRawPixels}x{_screenService.ScreenHeightInRawPixels}");
            client.DefaultRequestHeaders.Add("udid", Udid);
            return client;
        }
    }
}