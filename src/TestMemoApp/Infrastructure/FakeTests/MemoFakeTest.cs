using MemoApp.Infrastructure.Fake;

namespace TestMemoApp.Infrastructure.FakeTests
{
    [TestClass]
    public sealed class MemoFakeTest
    {
        [TestMethod]
        public async Task TestGetAllMemosAsync()
        {
            var fake = new MemoFake();
            var memos = await fake.GetAllEntitiesAsync();

            Assert.AreEqual(2, memos.Count);
            Assert.AreEqual("title1", memos[0].Title);
            Assert.AreEqual("メモの内容が入る", memos[0].Body);
            Assert.AreEqual("title2", memos[1].Title);
            Assert.AreEqual("内容が長い場合は1行で切れる。内容が長い場合は1行で切れる。内容が長い場合は1行で切れる。", memos[1].Body);
        }
    }
}
