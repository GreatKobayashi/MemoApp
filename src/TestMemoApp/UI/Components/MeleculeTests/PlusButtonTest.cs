using MemoApp.UI.Components.Molecules;

namespace TestMemoApp.UI.Components.MeleculeTests
{
    [TestClass]
    public sealed class PlusButtonTest
    {
        [TestMethod]
        public void TestParameters()
        {
            using var bUnit = new TestContext();

            var plusButton = bUnit.RenderComponent<PlusButton>();

            // TODO: 機能追加後、テストコードを追加する  
        }
    }
}
