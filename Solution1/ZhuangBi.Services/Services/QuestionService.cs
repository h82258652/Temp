using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ZhuangBi.Configuration;
using ZhuangBi.Models;

namespace ZhuangBi.Services
{
    public class QuestionService : ZhuangBiServiceBase, IQuestionService
    {
        public QuestionService(IZhuangBiSettings zhuangBiSettings) : base(zhuangBiSettings)
        {
        }

        protected override string ControllerName => "question";

        public async Task<ResultBase<GetAnswerResult>> GetAnswerAsync(int answerId)
        {
            using (var client = CreateHttpClient())
            {
                var url = $"{GetUrl("answer")}&answer_id={answerId}";
                var json = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ResultBase<GetAnswerResult>>(json);
            }
        }

        public Task GetAsync(int id, int page = 1, string sort_key = "agree_count", string sort = "DESC")
        {
            throw new NotImplementedException();
        }
    }
}