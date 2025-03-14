using MemoApp.Domain.Entities;
using MemoApp.Domain.Repositories;

namespace MemoApp.Infrastructure.Sqlite
{
    public class MemoSqlite : IMemoRepository
    {
        public Task<List<MemoEntity>> GetAllMemosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
