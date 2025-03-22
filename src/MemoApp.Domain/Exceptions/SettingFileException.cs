using MemoApp.Domain.Enums;

namespace MemoApp.Domain.Exceptions
{
    public class SettingFileException : MemoAppException
    {
        private static string _message = "設定ファイルの読み込みに失敗しました。";

        public SettingFileException() : base(ExceptionLevel.Fatal, _message)
        {
        }

        public SettingFileException(Exception innerException) : base(ExceptionLevel.Fatal, _message, innerException)
        {
        }
    }
}
