using MemoApp.Domain;

namespace TestMemoApp.Domain
{
    [TestClass]
    public sealed class SharedTest
    {
        [TestMethod]
        public void TestStaticField()
        {
            Assert.IsTrue(Shared.IsFake);
        }
    }
}
