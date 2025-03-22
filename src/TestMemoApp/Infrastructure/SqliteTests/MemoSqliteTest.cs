using MemoApp.Infrastructure.Sqlite;

namespace TestMemoApp.Infrastructure.SqliteTests
{
    [TestClass]
    public sealed class MemoSqliteTest
    {
        [TestMethod]
        public async Task TestGetAllMemosAsync()
        {
            var sqlite = new MemoSqlite();

            try
            {
                var memos = await sqlite.GetAllEntitiesAsync();
            }
            catch
            {
                // 未実装のため、例外が発生する
                // TODO: 実装後、テストを書き換える
            }
        }
    }
}
