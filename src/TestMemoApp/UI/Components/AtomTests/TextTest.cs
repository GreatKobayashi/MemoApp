

using MemoApp.UI.Components.Atoms;

namespace TestMemoApp.UI.Components.AtomTests
{
    [TestClass]
    public sealed class TextTest
    {
        [TestMethod]
        public void TestParameters()
        {
            using var bUnit = new TestContext();

            var inputFontSize = 10;
            var inputIsBold = true;
            var inputChildContent = "Test";
            var text = bUnit.RenderComponent<Text>(p =>
            {
                p.Add(x => x.FontSize, inputFontSize);
                p.Add(x => x.IsBold, inputIsBold);
                p.AddChildContent(inputChildContent);
            });

            var p = text.Find("p");
            var actualFontSize = p.GetStyle("font-size");
            var actualFontWeight = p.GetStyle("font-weight");

            Assert.AreEqual(inputFontSize.ToString() + "px", actualFontSize);
            Assert.AreEqual("bold", actualFontWeight);
            Assert.AreEqual(inputChildContent, p.TextContent);
        }

        [TestMethod]
        public void TestParametersDefaultFontSize()
        {
            using var bUnit = new TestContext();

            var inputIsBold = true;
            var inputChildContent = "Test";
            var text = bUnit.RenderComponent<Text>(p =>
            {
                p.Add(x => x.IsBold, inputIsBold);
                p.AddChildContent(inputChildContent);
            });

            var p = text.Find("p");
            var actualFontWeight = p.GetStyle("font-weight");

            Assert.AreEqual("bold", actualFontWeight);
            Assert.AreEqual(inputChildContent, p.TextContent);
        }
    }
}
