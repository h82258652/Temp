using SoftwareKobo.Utils;
using System.Net.Http;
using ZhuangBi.Configuration;
using ZhuangBi.Utils;

namespace ZhuangBi.Services
{
    public abstract class ZhuangBiServiceBase
    {
        private readonly IZhuangBiSettings _zhuangBiSettings;

        protected ZhuangBiServiceBase(IZhuangBiSettings zhuangBiSettings)
        {
            _zhuangBiSettings = zhuangBiSettings;
        }

        protected abstract string ControllerName
        {
            get;
        }

        protected HttpClient CreateHttpClient()
        {
            return new HttpClient(new ZhuangBiHttpClientHandler(_zhuangBiSettings));
        }

        protected string GetUrl(string actionName = "")
        {
            actionName = actionName ?? string.Empty;
            var controllerName = ControllerName;
            var url = string.Join("/", Constants.ZhuangBiApiUrlBase, controllerName, actionName);
            var sign = HashHelper.GenerateMD5Hash(controllerName + Constants.AppSecret).ToLower();
            return url + "?mobile_sign=" + sign;
        }
    }
}