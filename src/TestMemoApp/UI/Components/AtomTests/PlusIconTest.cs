using MemoApp.UI.Components.Atoms;

namespace TestMemoApp.UI.Components.AtomTests
{
    [TestClass]
    public sealed class PlusIconTest
    {
        [TestMethod]
        public void TestParameters()
        {
            using var bUnit = new TestContext();

            var inputSize = 10;
            var plusIcon = bUnit.RenderComponent<PlusIcon>(p => p.Add(x => x.Size, inputSize));

            var svg = plusIcon.Find("svg");
            var actualWidth = svg.GetAttribute("width");
            var actualHeight = svg.GetAttribute("height");

            Assert.AreEqual(inputSize.ToString(), actualWidth);
            Assert.AreEqual(inputSize.ToString(), actualHeight);
        }
    }
}
