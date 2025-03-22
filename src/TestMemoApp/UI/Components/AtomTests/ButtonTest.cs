using Button = MemoApp.UI.Components.Atoms.Button;

namespace TestMemoApp.UI.Components.AtomTests
{
    [TestClass]
    public class ButtonTest
    {
        [TestMethod]
        public void TestClick()
        {
            using var bUnit = new TestContext();

            var isClicked = false;
            var inputElement = "<div>Test</div>";
            var button = bUnit.RenderComponent<Button>(p =>
                {
                    p.Add(x => x.OnClick, () => { isClicked = true; });
                    p.AddChildContent(inputElement);
                });

            var buttonElement = button.Find("button");
            buttonElement.Children.MarkupMatches(inputElement);

            buttonElement.Click();
            Assert.IsTrue(isClicked);
        }

    }
}
