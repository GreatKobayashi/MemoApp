using MemoApp.UI;

namespace TestMemoApp.UI
{
    [TestClass]
    public sealed class UISettingsTest
    {
        [TestMethod]
        public void TestProperties()
        {
            // 現状あまり意味のないテスト
            Assert.AreEqual(new(229, 229, 234), UISettings.StatusBarColor);
            Assert.IsFalse(UISettings.IsDarkMode);
        }
    }
}
