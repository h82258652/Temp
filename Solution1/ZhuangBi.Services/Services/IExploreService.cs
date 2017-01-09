using System.Threading.Tasks;

namespace ZhuangBi.Services
{
    public interface IExploreService
    {
        Task<object> GetAsync(int page = 1, int? per_page = null, int day = 30, int is_recommend = 0, string sort_type = "new");
    }
}