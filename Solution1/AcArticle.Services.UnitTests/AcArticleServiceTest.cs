using AcArticle.Models;
using NUnit.Framework;
using SoftwareKobo.Support;
using System.Net;
using System.Threading.Tasks;

namespace AcArticle.Services.UnitTests
{
    [TestFixture]
    public class AcArticleServiceTest
    {
        private IAcArticleService _acArticleService;

        [SetUp]
        public void SetUp()
        {
            _acArticleService = new AcArticleService(new ScreenService());
        }

        [Test]
        public async Task TestGetArticleCommentsAsync()
        {
            var result = await _acArticleService.GetArticleCommentsAsync(3077950, 1, 20);
            Assert.True(result.Code == HttpStatusCode.OK);
        }

        [Test]
        public async Task TestGetArticleDetailAsync()
        {
            var result = await _acArticleService.GetArticleDetailAsync(3077950);
            Assert.True(result.Code == HttpStatusCode.OK);
        }

        [Test]
        public async Task TestGetArticlesAsync()
        {
            var result = await _acArticleService.GetArticlesAsync(Channel.Synthetical, 1, 20, Sort.PublishNewest);
            Assert.True(result.Code == HttpStatusCode.OK);
        }
    }
}