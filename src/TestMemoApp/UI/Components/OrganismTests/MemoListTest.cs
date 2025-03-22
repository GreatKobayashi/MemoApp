using MemoApp.Domain.Entities;
using MemoApp.UI.Components.Molecules;
using MemoApp.UI.Components.Organisms;

namespace TestMemoApp.UI.Components.OrganismTests
{
    [TestClass]
    public sealed class MemoListTest
    {
        [TestMethod]
        public void TestParameters()
        {
            using var bUnit = new TestContext();
            var inputMemos = new List<MemoEntity>
            {
                new ("inputTitle1", "inputBody1"),
                new ("inputTitle2", "inputBody2"),
                new ("inputTitle3", "inputBody3"),
            };
            var memoList = bUnit.RenderComponent<MemoList>(p =>
            {
                p.Add(x => x.Memos, inputMemos);
            });

            var memoColumns = memoList.FindComponents<MemoColumn>();

            for (var i = 0; i < inputMemos.Count; i++)
            {
                Assert.AreEqual(inputMemos[i], memoColumns[i].Instance.Memo);
            }
        }
    }
}
