using System;
using System.Threading.Tasks;
using ZhuangBi.Configuration;

namespace ZhuangBi.Services
{
    public class ExploreService : ZhuangBiServiceBase, IExploreService
    {
        public ExploreService(IZhuangBiSettings zhuangBiSettings) : base(zhuangBiSettings)
        {
        }

        protected override string ControllerName => "explore";

        public async Task<object> GetAsync(int page = 1, int? per_page = null, int day = 30, int is_recommend = 0, string sort_type = "new")
        {
            using (var client = CreateHttpClient())
            {
                var url = $"{GetUrl()}&page={page}&per_page={per_page}";
                await client.GetStringAsync(url);
            }

            throw new NotImplementedException();
        }
    }
}