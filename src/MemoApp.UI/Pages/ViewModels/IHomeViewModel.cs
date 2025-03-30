using MemoApp.Domain.Entities;

namespace MemoApp.UI.Pages.ViewModels
{
    public interface IHomeViewModel : IViewModelBase
    {
        public Task InitializeAsync();

        public List<MemoEntity>? Memos { get; }
    }
}
