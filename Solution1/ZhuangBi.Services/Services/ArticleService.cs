using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ZhuangBi.Configuration;
using ZhuangBi.Models;

namespace ZhuangBi.Services
{
    public class ArticleService : ZhuangBiServiceBase, IArticleService
    {
        public ArticleService(IZhuangBiSettings zhuangBiSettings) : base(zhuangBiSettings)
        {
        }

        protected override string ControllerName => "article";

        public async Task<ResultBase<GetArticleResult>> GetAsync(int id, int page = 1)
        {
            if (page < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(page));
            }

            using (var client = CreateHttpClient())
            {
                var url = $"{GetUrl()}&id={id}&page={page}";
                var json = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ResultBase<GetArticleResult>>(json);
            }
        }

        public async Task<ResultBase<SaveCommentResult>> SaveCommentAsync(int articleId, string message, int? atUid)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            var form = new Dictionary<string, string>()
            {
                ["article_id"] = articleId.ToString(),
                ["message"] = message
            };
            if (atUid.HasValue)
            {
                form["at_uid"] = atUid.Value.ToString();
            }
            var postContent = new FormUrlEncodedContent(form);
            using (var client = CreateHttpClient())
            {
                var url = GetUrl("save_comment");
                var response = await client.PostAsync(url, postContent);
                var json = await response.Content.ReadAsStringAsync();
                return
                JsonConvert.DeserializeObject<ResultBase<SaveCommentResult>>(json);
            }
        }
    }
}