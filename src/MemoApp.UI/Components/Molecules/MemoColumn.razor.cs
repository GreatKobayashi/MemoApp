using System.Text;

namespace MemoApp.UI.Components.Molecules
{
    partial class MemoColumn
    {
        private string GetMemoHeader(int headerLength)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // Shift-JISでのバイト数を取得する
            var encoding = Encoding.GetEncoding("shift_jis");
            var numberOfBytes = encoding.GetByteCount(Memo.Body);

            if (numberOfBytes <= headerLength)
            {
                return Memo.Body;
            }

            var header = new string(Memo.Body.TakeWhile((_, i) => encoding.GetByteCount(Memo.Body[0..i]) < headerLength).ToArray());
            return header + "…";
        }
    }
}
