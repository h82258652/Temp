using System;
using System.Threading.Tasks;
using ZhuangBi.Configuration;
using ZhuangBi.Models;

namespace ZhuangBi.Services
{
    public class InboxService : ZhuangBiServiceBase, IInboxService
    {
        public InboxService(IZhuangBiSettings zhuangBiSettings) : base(zhuangBiSettings)
        {
        }

        protected override string ControllerName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Task<object> GetAsync(int page, int per_page)
        {
            throw new NotImplementedException();
        }

        public Task<object> ReadAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultBase> SendAsync(string recipient, string message)
        {
            if (recipient == null)
            {
                throw new ArgumentNullException(nameof(recipient));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            using (var client = CreateHttpClient())
            {
                var url = GetUrl("");
                var response = await client.PostAsync(url, null);
            }

            throw new NotImplementedException();
        }
    }
}