using MemoApp.Domain.Entities;
using MemoApp.Domain.Repositories;
using MemoApp.UI.Pages.ViewModels;
using Moq;

namespace TestMemoApp.UI.Pages.ViewModelTests
{
    [TestClass]
    public sealed class HomeViewModelTest
    {
        private (Mock<IMemoRepository>, HomeViewModel) Setup()
        {
            var mock = new Mock<IMemoRepository>();
            var viewModel = new HomeViewModel(mock.Object);
            return (mock, viewModel);
        }

        [TestMethod]
        public async Task TestInitializeAsync()
        {
            (var mockMemoRepository, var viewModel) = Setup();

            var memoList = new List<MemoEntity>
            {
                new("title1", "body1"),
                new("title2", "body2")
            };

            mockMemoRepository.Setup(x => x.GetAllEntitiesAsync()).ReturnsAsync(memoList);

            await viewModel.InitializeAsync();

            Assert.IsTrue(viewModel.IsInitialized);
            CollectionAssert.AreEqual(memoList, viewModel.Memos);
        }
    }
}
