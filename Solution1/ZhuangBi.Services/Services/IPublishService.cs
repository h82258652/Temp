using System.Threading.Tasks;

namespace ZhuangBi.Services
{
    public interface IPublishService
    {
        Task<object> PublishQuestionAsync(string questionContent, string questionDetail, string attach_access_key = null, string topics = null, int category_id = 1);

        Task<object> attach_upload(string id);
    }
}