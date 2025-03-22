using MemoApp.Domain;
using MemoApp.Domain.Repositories;
using MemoApp.Infrastructure.Fake;
using MemoApp.Infrastructure.Json;
using MemoApp.Infrastructure.Sqlite;

namespace MemoApp.Infrastructure
{
    public static class Factories
    {
        public static IMemoRepository CreateMemoRepository()
        {
            if (Shared.IsFake)
            {
                return new MemoFake();
            }
            return new MemoSqlite();
        }

        public static ISettingRepository CreateSettingRepository(bool isFake = false)
        {
            if (isFake)
            {
                return new SettingFake();
            }
            return new SettingJson(FileSystem.Current);
        }
    }
}
