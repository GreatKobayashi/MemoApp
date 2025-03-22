using MemoApp.UI;
using MemoApp.UI.Components.Organisms;

namespace TestMemoApp.UI.Components.OrganismTests
{
    [TestClass]
    public sealed class TitleBarTest
    {
        [TestMethod]
        public void TestParameters()
        {
            using var bUnit = new TestContext();
            var titleBar = bUnit.RenderComponent<TitleBar>();

            var h3 = titleBar.Find("h3");
            var actualBgColor = h3.GetStyle("background-color");

            Assert.AreEqual(UISettings.StatusBarColor.ToHex(), actualBgColor);
        }
    }
}
