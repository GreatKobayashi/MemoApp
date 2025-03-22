using MemoApp.Domain.Enums;
using MemoApp.Domain.Exceptions;

namespace TestMemoApp.Domain.ExceptionTests
{
    [TestClass]
    public sealed class SettingFileExceptionTest
    {
        private static string _message = "設定ファイルの読み込みに失敗しました。";

        [TestMethod]
        public void TestConstructor()
        {
            var exception = new SettingFileException();

            Assert.AreEqual(_message, exception.Message);
            Assert.AreEqual(ExceptionLevel.Fatal, exception.Level);
        }

        [TestMethod]
        public void TestConstructorWithInnerException()
        {
            var inputInnerException = new Exception();

            var exception = new SettingFileException(inputInnerException);

            Assert.AreEqual(_message, exception.Message);
            Assert.AreEqual(ExceptionLevel.Fatal, exception.Level);
            Assert.AreEqual(inputInnerException, exception.InnerException);
        }
    }
}
