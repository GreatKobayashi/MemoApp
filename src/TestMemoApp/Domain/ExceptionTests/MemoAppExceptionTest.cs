using MemoApp.Domain.Enums;
using MemoApp.Domain.Exceptions;

namespace TestMemoApp.Domain.ExceptionTests
{
    [TestClass]
    public sealed class MemoAppExceptionTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            var inputMessage = "message";
            var inputExceptionLevel = ExceptionLevel.Info;

            var actualException = new MemoAppException(inputExceptionLevel, inputMessage);

            Assert.AreEqual(inputMessage, actualException.Message);
            Assert.AreEqual(inputExceptionLevel, actualException.Level);
        }

        [TestMethod]
        public void TestConstructorWithInnerException()
        {
            var inputMessage = "message";
            var inputExceptionLevel = ExceptionLevel.Info;
            var inputInnerException = new Exception();

            var actualException = new MemoAppException(inputExceptionLevel, inputMessage, inputInnerException);

            Assert.AreEqual(inputMessage, actualException.Message);
            Assert.AreEqual(inputExceptionLevel, actualException.Level);
            Assert.AreEqual(inputInnerException, actualException.InnerException);
        }
    }
}
