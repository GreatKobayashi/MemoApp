using MemoApp.Domain.Entities;
using MemoApp.Domain.Repositories;

namespace MemoApp.Infrastructure.Fake
{
    public class MemoFake : IMemoRepository
    {
        public async Task<List<MemoEntity>> GetAllEntitiesAsync()
        {
            var dummy = new List<MemoEntity>()
            {
                new("title1", "メモの内容が入る"),
                new("title2", "内容が長い場合は1行で切れる。内容が長い場合は1行で切れる。内容が長い場合は1行で切れる。")
            };

            await Task.Delay(100);
            return dummy;
        }
    }
}
