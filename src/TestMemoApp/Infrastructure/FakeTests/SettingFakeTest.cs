using MemoApp.Infrastructure.Fake;

namespace TestMemoApp.Infrastructure.FakeTests
{
    [TestClass]
    public class SettingFakeTest
    {
        [TestMethod]
        public void TestGetEntity()
        {
            var settingFake = new SettingFake();
            var entity = settingFake.GetEntity();
            Assert.IsTrue(entity.IsFake);
        }
    }
}
