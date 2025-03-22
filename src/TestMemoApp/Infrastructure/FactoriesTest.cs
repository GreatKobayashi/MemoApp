using MemoApp.Domain;
using MemoApp.Infrastructure;
using MemoApp.Infrastructure.Fake;
using MemoApp.Infrastructure.Json;
using MemoApp.Infrastructure.Sqlite;

namespace TestMemoApp.Infrastructure
{
    [TestClass]
    public sealed class FactoriesTest
    {
        [TestMethod]
        public void TestCreateMemoRepositoryFake()
        {
            Shared.Setup(new() { IsFake = true });
            var actualRepository = Factories.CreateMemoRepository();

            Assert.IsInstanceOfType(actualRepository, typeof(MemoFake));
        }

        [TestMethod]
        public void TestCreateMemoRepositorySqlite()
        {
            Shared.Setup(new() { IsFake = false });
            var actualRepository = Factories.CreateMemoRepository();

            Assert.IsInstanceOfType(actualRepository, typeof(MemoSqlite));
        }

        [TestMethod]
        public void TestCreateSettingRepositoryFake()
        {
            var actualRepository = Factories.CreateSettingRepository(true);
            Assert.IsInstanceOfType(actualRepository, typeof(SettingFake));
        }

        [TestMethod]
        public void TestCreateSettingRepositoryJson()
        {
            var actualRepository = Factories.CreateSettingRepository();
            Assert.IsInstanceOfType(actualRepository, typeof(SettingJson));
        }
    }
}
