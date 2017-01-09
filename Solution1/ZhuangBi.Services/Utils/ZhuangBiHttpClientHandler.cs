using SoftwareKobo.Extensions;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ZhuangBi.Configuration;

namespace ZhuangBi.Utils
{
    internal class ZhuangBiHttpClientHandler : HttpClientHandler
    {
        private readonly IZhuangBiSettings _zhuangBiSettings;

        internal ZhuangBiHttpClientHandler(IZhuangBiSettings zhuangBiSettings)
        {
            _zhuangBiSettings = zhuangBiSettings;
            CookieContainer = new CookieContainer();
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var cookieContainer = CookieContainer;
            cookieContainer?.Load(_zhuangBiSettings.Cookie);
            try
            {
                return base.SendAsync(request, cancellationToken);
            }
            finally
            {
                if (cancellationToken.IsCancellationRequested == false && cookieContainer != null)
                {
                    _zhuangBiSettings.Cookie = cookieContainer.Save();
                }
            }
        }
    }
}