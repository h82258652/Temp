using System.Threading.Tasks;
using ZhuangBi.Models;

namespace ZhuangBi.Services
{
    public interface IAccountService
    {
        /// <summary>
        /// 上传用户头像
        /// </summary>
        /// <param name="userAvatar">图片文件域</param>
        /// <returns></returns>
        Task<ResultBase<AvatarUploadResult>> AvatarUploadAsync(string userAvatar);

        /// <summary>
        /// 获取职业(职位)列表
        /// </summary>
        /// <returns></returns>
        Task<ResultBase<JobsList>> GetJobsListAsync();

        /// <summary>
        /// 获取当前用户UID
        /// </summary>
        /// <returns></returns>
        Task<ResultBase<GetUidResult>> GetUidAsync();

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="uid">用户编号</param>
        /// <returns></returns>
        Task<ResultBase<UserInfo>> GetUserInfoAsync(int uid);

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName">用户名,邮箱</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        Task<ResultBase<LoginResult>> LoginAsync(string userName, string password);

        /// <summary>
        /// 退出
        /// </summary>
        /// <returns></returns>
        Task<ResultBase> LogoutAsync();

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="oldPassword">旧密码</param>
        /// <param name="newPassword">新密码</param>
        /// <returns></returns>
        Task<ResultBase<string>> ModifyPasswordAsync(string oldPassword, string newPassword);

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="email">邮箱</param>
        /// <param name="invitationCode">邀请码</param>
        /// <returns></returns>
        Task<ResultBase<RegisterResult>> RegisterAsync(string userName, string password, string email, string invitationCode = null);
    }
}