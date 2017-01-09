using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ZhuangBi.Configuration;
using ZhuangBi.Models;

namespace ZhuangBi.Services
{
    public class AccountService : ZhuangBiServiceBase, IAccountService
    {
        public AccountService(IZhuangBiSettings zhuangBiSettings) : base(zhuangBiSettings)
        {
        }

        protected override string ControllerName => "account";

        public async Task<ResultBase<AvatarUploadResult>> AvatarUploadAsync(string userAvatar)
        {
            if (userAvatar == null)
            {
                throw new ArgumentNullException(nameof(userAvatar));
            }

            var form = new Dictionary<string, string>()
            {
                ["user_avatar"] = userAvatar
            };
            var postContent = new FormUrlEncodedContent(form);
            using (var client = CreateHttpClient())
            {
                var url = GetUrl("avatar_upload");
                var response = await client.PostAsync(url, postContent);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ResultBase<AvatarUploadResult>>(json);
            }
        }

        public async Task<ResultBase<JobsList>> GetJobsListAsync()
        {
            using (var client = CreateHttpClient())
            {
                var url = GetUrl("get_jobs_list");
                var json = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ResultBase<JobsList>>(json);
            }
        }

        public async Task<ResultBase<GetUidResult>> GetUidAsync()
        {
            using (var client = CreateHttpClient())
            {
                var url = GetUrl("get_uid");
                var json = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ResultBase<GetUidResult>>(json);
            }
        }

        public async Task<ResultBase<UserInfo>> GetUserInfoAsync(int uid)
        {
            using (var client = CreateHttpClient())
            {
                var url = $"{GetUrl("get_userinfo")}&uid={uid}";
                var json = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ResultBase<UserInfo>>(json);
            }
        }

        public async Task<ResultBase<LoginResult>> LoginAsync(string userName, string password)
        {
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            var form = new Dictionary<string, string>()
            {
                ["user_name"] = userName,
                ["password"] = password
            };
            var postContent = new FormUrlEncodedContent(form);
            using (var client = CreateHttpClient())
            {
                var url = GetUrl("login_process");
                var response = await client.PostAsync(url, postContent);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ResultBase<LoginResult>>(json);
            }
        }

        public async Task<ResultBase> LogoutAsync()
        {
            using (var client = CreateHttpClient())
            {
                var url = GetUrl("logout");
                var json = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ResultBase>(json);
            }
        }

        public async Task<ResultBase<string>> ModifyPasswordAsync(string oldPassword, string newPassword)
        {
            if (oldPassword == null)
            {
                throw new ArgumentNullException(nameof(oldPassword));
            }
            if (newPassword == null)
            {
                throw new ArgumentNullException(nameof(newPassword));
            }

            var form = new Dictionary<string, string>()
            {
                ["old_password"] = oldPassword,
                ["password"] = newPassword,
                ["re_password"] = newPassword
            };
            var postContent = new FormUrlEncodedContent(form);
            using (var client = CreateHttpClient())
            {
                var url = GetUrl("modify_password");
                var response = await client.PostAsync(url, postContent);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ResultBase<string>>(json);
            }
        }

        public async Task<ResultBase<RegisterResult>> RegisterAsync(string userName, string password, string email, string invitationCode = null)
        {
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            var form = new Dictionary<string, string>()
            {
                ["user_name"] = userName,
                ["password"] = password,
                ["email"] = email
            };
            if (invitationCode != null)
            {
                form["icode"] = invitationCode;
            }
            var postContent = new FormUrlEncodedContent(form);
            using (var client = CreateHttpClient())
            {
                var url = GetUrl("register_process");
                var response = await client.PostAsync(url, postContent);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ResultBase<RegisterResult>>(json);
            }
        }
    }
}