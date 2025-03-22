using MemoApp.Domain.Entities;

namespace TestMemoApp.Domain.EntityTests
{
    [TestClass]
    public sealed class MemoEntityTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            var inputTitle = "title";
            var inputBody = "body";

            var actualMemo = new MemoEntity(inputTitle, inputBody);
            Assert.AreEqual(inputTitle, actualMemo.Title);
            Assert.AreEqual(inputBody, actualMemo.Body);
        }
    }
}
