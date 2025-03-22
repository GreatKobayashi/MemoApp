using MemoApp.Domain.Entities;
using MemoApp.Domain.Repositories;
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
            var mockRepository = new Mock<IMemoRepository>();
            var viewModel = new HomeViewModel(mockRepository.Object);
            mockRepository.SetupSequence(x => x.GetAllEntitiesAsync())
                .ReturnsAsync(new List<MemoEntity> { new("title", "body") });
            var services = new ServiceCollection();

            using var bUnit = new TestContext();
            bUnit.Services.AddSingleton(viewModel);

            var homeView = bUnit.RenderComponent<HomeView>();
            await Task.Delay(100);

            mockRepository.Verify(x => x.GetAllEntitiesAsync(), Times.Once);
            Assert.IsTrue(viewModel.IsInitialized);

            var memoList = homeView.FindComponent<MemoList>();
            var plusButton = homeView.FindComponent<PlusButton>();
            plusButton.Find("button").Click();

            // TODO: ページ遷移実装後に追加
        }
    }
}
