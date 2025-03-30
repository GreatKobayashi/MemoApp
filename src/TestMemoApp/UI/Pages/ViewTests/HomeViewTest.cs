using MemoApp.Domain.Entities;
using MemoApp.UI.Components.Molecules;
using MemoApp.UI.Components.Organisms;
using MemoApp.UI.Pages.ViewModels;
using MemoApp.UI.Pages.Views;
using Moq;

namespace TestMemoApp.UI.Pages.ViewTests
{
    [TestClass]
    public sealed class HomeViewTest
    {
        [TestMethod]
        public async Task TestLifeCycleAndEvents()
        {
            var mockViewModel = new Mock<IHomeViewModel>();
            mockViewModel.Setup(x => x.IsInitialized).Returns(true);
            mockViewModel.Setup(x => x.Memos).Returns(new List<MemoEntity> { new("title1", "body1") });

            using var bUnit = new TestContext();
            bUnit.Services.AddSingleton(mockViewModel.Object);

            var homeView = bUnit.RenderComponent<HomeView>();
            await Task.Delay(100);

            mockViewModel.Verify(x => x.InitializeAsync(), Times.Once);

            var memoList = homeView.FindComponent<MemoList>();
            var plusButton = homeView.FindComponent<PlusButton>();
            plusButton.Find("button").Click();

            // TODO: ページ遷移実装後に追加
        }
    }
}
