using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ZhuangBi.Configuration;
using ZhuangBi.Models;

namespace ZhuangBi.Services
{
    public class PeopleService : ZhuangBiServiceBase, IPeopleService
    {
        public PeopleService(IZhuangBiSettings zhuangBiSettings) : base(zhuangBiSettings)
        {
        }

        protected override string ControllerName => "people";

        public async Task<ResultBase<GetFollowsResult>> GetFollowsAsync(int uid, GetFollowType type, int page = 1, int perPage = 10)
        {
            if (Enum.IsDefined(typeof(GetFollowType), type) == false)
            {
                throw new ArgumentOutOfRangeException(nameof(type));
            }
            if (page < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(page));
            }

            using (var client = CreateHttpClient())
            {
                var url = $"{GetUrl("follows")}&uid={uid}&type={type}&page={page}&per_page={perPage}";
                var json = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ResultBase<GetFollowsResult>>(json);
            }
        }

        public async Task<ResultBase> profile_setting(ProfileSetting profileSetting)
        {
            if (profileSetting == null)
            {
                throw new ArgumentNullException(nameof(profileSetting));
            }

            var form = JsonConvert.DeserializeObject<Dictionary<string, string>>(JsonConvert.SerializeObject(profileSetting));
            var postContent = new FormUrlEncodedContent(form);
            using (var client = CreateHttpClient())
            {
                var url = GetUrl("profile_setting");
                var response = await client.PostAsync(url, postContent);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ResultBase>(json);
            }
        }

        public async Task<ResultBase<TopicsResult>> GetTopicsAsync(int uid, int page = 1)
        {
            if (page < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(page));
            }

            using (var client = CreateHttpClient())
            {
                var url = $"{GetUrl("topics")}&uid={uid}&page={page}";
                var json = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ResultBase<TopicsResult>>(json);
            }
        }

        public async Task<ResultBase> user_actions(AssociateAction actions, int uid, int per_page = 10, int page = 1)
        {
            if (Enum.IsDefined(typeof(AssociateAction), actions) == false)
            {
                throw new ArgumentOutOfRangeException(nameof(actions));
            }
            if (page < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(page));
            }

            using (var client = CreateHttpClient())
            {
                var url = $"{GetUrl("user_actions")}&actions={(int)actions}&uid={uid}&per_page={per_page}&page={page}";
                var json = await client.GetStringAsync(url);
                JsonConvert.DeserializeObject(json);
            }

            throw new NotImplementedException();
        }

        public Task<ResultBase<GetUserActionsArticleResult>> GetUserActionsArticleAsync(int uid, int per_page = 10, int page = 1)
        {
            throw new NotImplementedException();
        }
    }
}