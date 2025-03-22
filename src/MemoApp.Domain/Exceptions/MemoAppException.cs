using MemoApp.Domain.Enums;

namespace MemoApp.Domain.Exceptions
{
    public class MemoAppException : Exception
    {
        public ExceptionLevel Level { get; }

        public MemoAppException(ExceptionLevel level, string message) : base(message)
        {
            Level = level;
        }

        public MemoAppException(ExceptionLevel level, string message, Exception innerException) : base(message, innerException)
        {
            Level = level;
        }
    }
}
