using MemoApp.Domain;
using MemoApp.Domain.Exceptions;
using MemoApp.Infrastructure.Json;
using Moq;
using System.Text;

namespace TestMemoApp.Infrastructure
{
    [TestClass]
    public sealed class SettingLoaderTest
    {
        [TestMethod]
        public void TestGetEntity()
        {
            var mockFileSystem = new Mock<IFileSystem>();
            mockFileSystem.SetupSequence(x => x.OpenAppPackageFileAsync(Shared.SettingFilePath))
                .ReturnsAsync(new MemoryStream(Encoding.UTF8.GetBytes("{\"IsFake\":false}")));

            var settingLoader = new SettingJson(mockFileSystem.Object);
            var entity = settingLoader.GetEntity();

            Assert.IsFalse(entity.IsFake);
        }

        [TestMethod]
        public void TestGetEntityFailed()
        {
            var mockFileSystem = new Mock<IFileSystem>();
            mockFileSystem.SetupSequence(x => x.OpenAppPackageFileAsync(Shared.SettingFilePath))
                .ReturnsAsync(new MemoryStream());

            var settingJson = new SettingJson(mockFileSystem.Object);

            try
            {
                settingJson.GetEntity();
                Assert.Fail();
            }
            catch (SettingFileException e)
            {
                Assert.IsNotNull(e.InnerException);
            }
        }
    }
}
