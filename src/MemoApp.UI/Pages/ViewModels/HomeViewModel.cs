using MemoApp.Domain.Entities;
using MemoApp.Domain.Repositories;

namespace MemoApp.UI.Pages.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly IMemoRepository _memoRepository;

        public HomeViewModel(IMemoRepository memoRepository)
        {
            _memoRepository = memoRepository;
        }

        public async Task InitializeAsync()
        {
            Memos = await _memoRepository.GetAllEntitiesAsync();
            IsInitialized = true;
        }

        public List<MemoEntity>? Memos { get; private set; }
    }
}
