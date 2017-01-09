using System.Threading.Tasks;
using ZhuangBi.Models;

namespace ZhuangBi.Services
{
    public interface IInboxService
    {
        Task<ResultBase> SendAsync(string recipient, string message);

        Task<object> GetAsync(int page, int per_page);

        Task<object> ReadAsync(int id);
    }
}