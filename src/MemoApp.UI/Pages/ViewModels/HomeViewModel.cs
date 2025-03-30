using MemoApp.Domain.Entities;
using MemoApp.Domain.Repositories;

namespace MemoApp.UI.Pages.ViewModels
{
    public class HomeViewModel : IHomeViewModel
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

        public bool IsInitialized { get; private set; }
        public List<MemoEntity>? Memos { get; private set; }
    }
}
