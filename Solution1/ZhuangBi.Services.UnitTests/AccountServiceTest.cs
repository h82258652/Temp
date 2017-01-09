using NUnit.Framework;
using System.Threading.Tasks;

namespace ZhuangBi.Services.UnitTests
{
    [TestFixture]
    public class AccountServiceTest
    {
        private IAccountService _accountService;

        [SetUp]
        public void SetUp()
        {
            _accountService = new AccountService(new TestZhuangBiSettings());
        }

        [Test]
        public async Task TestLoginAsync()
        {
            var result = await _accountService.LoginAsync("842053625@qq.com", "842053625");
            Assert.AreEqual(result.ErrorCode, 1);
        }

        [Test]
        public async Task TestLogoutAsync()
        {
            var result = await _accountService.LogoutAsync();
            Assert.AreEqual(result.ErrorCode, 1);
        }
    }
}