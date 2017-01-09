using AiXiFan.Models;
using NUnit.Framework;
using System.Threading.Tasks;

namespace AiXiFan.Services.UnitTests
{
    [TestFixture]
    public class AiXiFanServiceTest
    {
        private IAiXiFanService _aiXiFanService;

        [SetUp]
        public void SetUp()
        {
            _aiXiFanService = new AiXiFanService();
        }

        [Test]
        public async Task TestGetArticleAsync()
        {
            var result = await _aiXiFanService.GetArticleAsync(3077950);
            Assert.AreEqual(result.Code, 200);
        }

        [Test]
        public async Task TestGetChannelsAsync()
        {
            var result = await _aiXiFanService.GetChannelsAsync();
            Assert.AreEqual(result.Code, 200);
        }

        [Test]
        public async Task TestGetRegionAsync()
        {
            var result = await _aiXiFanService.GetRegionAsync(0, null);
            Assert.AreEqual(result.Code, 200);
        }

        [Test]
        public async Task TestGetUpdateCountsAsync()
        {
            var result = await _aiXiFanService.GetUpdateCountsAsync(155, 1, 60, 59, 68, 58, 123, 70, 69, 124, 125, 63);
            Assert.True(result.Success);
        }

        [Test]
        public async Task TestGetVideoAsync()
        {
            var result = await _aiXiFanService.GetVideoAsync(3079310);
            Assert.AreEqual(result.Code, 200);
        }

        [Test]
        public async Task TestSearchAsync()
        {
            var result = await _aiXiFanService.SearchAsync(73, 1, 20, Sort.ReplyNewest);
            Assert.AreEqual(result.Code, 200);
        }
    }
}