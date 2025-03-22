using MemoApp.Domain.Entities;

namespace MemoApp.Domain.Repositories
{
    public interface IMemoRepository
    {
        public Task<List<MemoEntity>> GetAllEntitiesAsync();
    }
}
