using MemoApp.Domain.Entities;
using MemoApp.UI.Components.Molecules;

namespace TestMemoApp.UI.Components.MeleculeTests
{
    [TestClass]
    public sealed class MemoColumnTest
    {
        [TestMethod]
        public void TestParameters()
        {
            using var bUnit = new TestContext();
            var inputMemo = new MemoEntity("inputTitle", "inputBody");
            var memoColumn = bUnit.RenderComponent<MemoColumn>(p =>
            {
                p.Add(x => x.Memo, inputMemo);
            });

            var titleElement = memoColumn.Find("[data-type=\"title\"]");
            var headerElement = memoColumn.Find("[data-type=\"header\"]");
            var actualTitle = titleElement.QuerySelector("p")!.TextContent;
            var actualHeader = headerElement.QuerySelector("p")!.TextContent;

            Assert.AreEqual(inputMemo.Title, actualTitle);
            Assert.AreEqual(inputMemo.Body, actualHeader);
        }

        [TestMethod]
        public void TestParametersLongBody()
        {
            using var bUnit = new TestContext();
            var inputMemo = new MemoEntity("inputTitle", "inputLongBodyInputLongBodyInputLongBodyInputLongBody");
            var memoColumn = bUnit.RenderComponent<MemoColumn>(p =>
            {
                p.Add(x => x.Memo, inputMemo);
            });

            var titleElement = memoColumn.Find("[data-type=\"title\"]");
            var headerElement = memoColumn.Find("[data-type=\"header\"]");
            var actualTitle = titleElement.QuerySelector("p")!.TextContent;
            var actualHeader = headerElement.QuerySelector("p")!.TextContent;

            Assert.AreEqual(inputMemo.Title, actualTitle);
            Assert.AreEqual("inputLongBodyInputLongBodyInputLongB…", actualHeader);
        }
    }
}
